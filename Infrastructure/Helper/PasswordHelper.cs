using Konscious.Security.Cryptography;
using System;
using System.Collections;
using System.Text;

public class PasswordHelper : IPasswordHelper
{
    // Hash the password with Argon2
    public string HashPassword(string password)
    {
        byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
        byte[] salt = new byte[16]; // You should generate a unique salt for each password
        new System.Security.Cryptography.RNGCryptoServiceProvider().GetBytes(salt); // Generate random salt

        using (var argon2 = new Argon2id(passwordBytes))
        {
            argon2.Salt = salt;
            argon2.DegreeOfParallelism = 8; // Controls the number of threads used
            argon2.MemorySize = 1024 * 1024; // Memory cost (e.g., 1 GB)
            argon2.Iterations = 4; // Number of iterations (higher is more secure)
            byte[] hash = argon2.GetBytes(32); // The length of the resulting hash

            // Return a combination of salt and hash to store in the database
            byte[] combined = new byte[salt.Length + hash.Length];
            Array.Copy(salt, 0, combined, 0, salt.Length);
            Array.Copy(hash, 0, combined, salt.Length, hash.Length);
            return Convert.ToBase64String(combined); // Store this in the database
        }
    }

    // Verify entered password against the stored hash
    public bool VerifyPassword(string enteredPassword, string storedHash)
    {
        byte[] storedHashBytes = Convert.FromBase64String(storedHash);
        byte[] salt = new byte[16];
        Array.Copy(storedHashBytes, 0, salt, 0, salt.Length);
        byte[] storedPasswordHash = new byte[storedHashBytes.Length - salt.Length];
        Array.Copy(storedHashBytes, salt.Length, storedPasswordHash, 0, storedPasswordHash.Length);

        byte[] enteredPasswordBytes = Encoding.UTF8.GetBytes(enteredPassword);

        using (var argon2 = new Argon2id(enteredPasswordBytes))
        {
            argon2.Salt = salt;
            argon2.DegreeOfParallelism = 8;
            argon2.MemorySize = 1024 * 1024;
            argon2.Iterations = 4;
            byte[] enteredPasswordHash = argon2.GetBytes(32);

            // Compare entered password hash with stored hash
            return StructuralComparisons.StructuralEqualityComparer.Equals(enteredPasswordHash, storedPasswordHash);
        }
    }
}

public interface IPasswordHelper
{
    string HashPassword(string password);
    bool VerifyPassword(string enteredPassword, string storedHash);
}
