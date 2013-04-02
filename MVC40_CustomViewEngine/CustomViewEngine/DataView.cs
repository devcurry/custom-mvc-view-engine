using MVC40_CustomViewEngine.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVC40_CustomViewEngine.CustomViewEngine
{
    /// <summary>
    /// Class for defining the actual View. This class is actual responsible for defining the HTML layouting
    /// of the view.
    /// </summary>
    public class DataView : IView
    {

        /// <summary>
        /// The Method used to Render the HTML
        /// </summary>
        /// <param name="viewContext"></param>
        /// <param name="writer"></param>
        public void Render(ViewContext viewContext, System.IO.TextWriter writer)
        {
            //Step 1 => Get the Model Bind with the View. (Note, this value is received from the controller)
            var Model = viewContext.ViewData.Model;

            var Emps = Model as List<EmployeeInfo>;

            //Step 2 => Now Geterate the HTML Table

            writer.Write("<table border=1><tr><th>EmpNo</th><th>EmpName</th><th>DeptName</th><th>Designation</th><th>Salary</th></tr>");
            foreach (EmployeeInfo Emp in Emps)
            {
                writer.Write("<tr><td>"+Emp.EmpNo+"</td><td>"+Emp.EmpName+"</td><td>"+Emp.DeptName+"</td><td>"+Emp.Designation+"</td><td>"+Emp.Salary+"</td></tr>");
            }

            writer.Write("</table>");
        }
    }
}