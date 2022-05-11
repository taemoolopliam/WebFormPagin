using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication4.Data;

namespace WebApplication4.Module
{
    public partial class Employee : Page
    {
        private readonly AdventureWorksDW2019Entities _db = new AdventureWorksDW2019Entities();
        private static string search = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData(0, "");
            }

        }

        private void LoadData(int pageIndex, string keysearch)
        {
            var query = _db.DimEmployees.AsQueryable();
            keysearch = keysearch.Trim();
            search = keysearch;
            if (!string.IsNullOrEmpty(keysearch))
            {
                query = query.Where(a => a.DepartmentName.Contains(keysearch) || (a.Title + " " + a.FirstName + " " + a.LastName).Contains(keysearch));
            }
            var data = query.OrderBy(a => a.EmployeeKey).Skip((pageIndex) * 10).Take(10).Select(a => new
            {
                EmployeeID = a.EmployeeKey,
                EmployeeName = a.Title + " " + a.FirstName + " " + a.LastName,
                Department = a.DepartmentName,
                Email = a.EmailAddress,
                a.Phone
            }).ToList();
            empTable.VirtualItemCount = query.Count();
            empTable.DataSource = data;
            empTable.DataBind();
        }

        protected void empTable_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            empTable.PageIndex = e.NewPageIndex;
            LoadData(e.NewPageIndex, search);
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            LoadData(1, TextBox1.Text);
        }
    }
}