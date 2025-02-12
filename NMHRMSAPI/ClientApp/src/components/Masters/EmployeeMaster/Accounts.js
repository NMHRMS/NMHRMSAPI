import React from 'react'

export default function Accounts() {
  return (
    <div style={{marginBottom:'200px',backgroundColor:"white",height:"100vh"}} className='p-4'>
      <label className='mb-2 fw-bold'>Bank Details</label>

      <div className="row mb-4">
        <div className="col-lg-3">
          <label htmlFor="firstName" className="form-label rounded rounded-pill">Bank Name</label>
          <select className="form-select rounded-5" placeholder="State" style={{ backgroundColor: "#f5f6fa", }}>
            <option>Select Bank</option>
          </select>
      </div>
        <div className="col-lg-3">
          <label htmlFor="middleName" className="form-label">Account Number</label>
          <input type="text" className="form-control rounded-5" id="accountNumber" placeholder="Enter" style={{ backgroundColor: "#f5f6fa", }} />
        </div>
        <div className="col-lg-3">
          <label htmlFor="lastName" className="form-label">IFSC Code</label>
          <input type="text" className="form-control rounded-5" id="IFSCCode" placeholder="Enter" style={{ backgroundColor: "#f5f6fa", }} />
        </div>
        <div className="col-lg-3">
          <label htmlFor="dob" className="form-label">Bank Branch</label>
          <input type="" className="form-control rounded-5" id="bankBranch"  placeholder="Enter" style={{ backgroundColor: "#f5f6fa", }} />
        </div>
      </div>
      <hr/>
      <div className="row mb-3">
        <div className="col-lg-3">
          <label htmlFor="firstName" className="form-label rounded rounded-pill">Adhar Card</label>
          <select className="form-select rounded-5" placeholder="State" style={{ backgroundColor: "#f5f6fa", }}>
            <option>Select Adhar</option>
          </select>
      </div>
        <div className="col-lg-3">
          <label htmlFor="middleName" className="form-label">Date of Confirmation</label>
          <input type="text" className="form-control rounded-5" id="dofconfimation" placeholder="Enter" style={{ backgroundColor: "#f5f6fa", }} />
        </div>
        <div className="col-lg-3">
          <label htmlFor="lastName" className="form-label">Offical Mobile</label>
          <input type="text" className="form-control rounded-5" id="IFSCCode" placeholder="Enter" style={{ backgroundColor: "#f5f6fa", }} />
        </div>
        <div className="col-lg-3">
          <label htmlFor="dob" className="form-label">Offical Email</label>
          <input type="" className="form-control rounded-5" id="bankBranch"  placeholder="Enter" style={{ backgroundColor: "#f5f6fa", }} />
        </div>
        <div className="col-lg-3">
          <label htmlFor="lastName" className="form-label">Biometric Code</label>
          <input type="text" className="form-control rounded-5" id="IFSCCode" placeholder="Enter" style={{ backgroundColor: "#f5f6fa", }} />
        </div>
        <div className="col-lg-3">
          <label htmlFor="dob" className="form-label">Notice Period(Month)</label>
          <input type="" className="form-control rounded-5" id="bankBranch"  placeholder="Enter" style={{ backgroundColor: "#f5f6fa", }} />
        </div>
      </div>
        
      <div className="text-end">
        <button type="button" className="btn btn-primary rounded-5 mb-2">Save</button>
      </div>

    </div>

    
  )
}
