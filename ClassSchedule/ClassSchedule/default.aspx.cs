using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassSchedule
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetClassScheduleData();
        }

        protected void GetClassScheduleData()
        {
            List<ClassSchedule> schedule = ClassSchedule.GetClassScheduleData();
            gridView_Schedule.DataSource = schedule;
            gridView_Schedule.DataBind();
            //removes the default border="1" from the generated grid view
            gridView_Schedule.GridLines = GridLines.None;
            //sets cellspacing to zero
            gridView_Schedule.CellSpacing = 0;
        }

        protected void gridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (((int)DataBinder.Eval(e.Row.DataItem, "remainSeats")) <= 0)
                {
                    e.Row.CssClass = "closed";
                }
                else if ((((string)DataBinder.Eval(e.Row.DataItem, "meetInfo")) == "LAB"))
                {
                    e.Row.CssClass = "lab";
                }
            }
        }


    }
}