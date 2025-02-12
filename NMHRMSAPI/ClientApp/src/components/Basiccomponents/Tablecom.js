import React from 'react'
import { DeleteOutlined, EditTwoTone } from "@ant-design/icons";

function Tablecom({headers,data,editdata,deletedata,keys}) {
  console.log("keys",keys);
  console.log("data",data);
  
  return (
    <div className="shadow-sm p-3 mb-5 bg-body rounded">
    <table className="table table-bordered">
    <thead>
        <tr>
          {headers.map((header, index) => (
            <th key={index} className='bg-primary text-white'>{header}</th>
          ))}
        </tr>
      </thead>
      <tbody>
        {data.length > 0 ? (
          data.map((row, rowIndex) => (
            <tr key={rowIndex}>
             {keys.map((key,colindex)=>{
               if (key === "SR.NO") {
                return <td key={colindex}>{rowIndex + 1}</td>;
              }
              return(
                <td key={colindex}>{row[key] || "N/A"}</td>

              )

              })}
                 <td className="text-center">
                      <button
                        className="btn btn-link p-1"
                        onClick={() => editdata(row)}
                      >
                        <EditTwoTone />
                      </button>
                      <button
                        className="btn btn-link p-1 text-danger"
                        onClick={() => deletedata(row.id)}
                      >
                        <DeleteOutlined />
                      </button>
                    </td>
            </tr>
          ))
        ) : (
          <tr>
            <td colSpan={headers.length} style={{ textAlign: "center" }}>
              No Data Available
            </td>
          </tr>
        )}
      </tbody>
    </table>
  </div>
  )
}

export default Tablecom