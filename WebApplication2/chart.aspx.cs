using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class chart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var start = new
            {
                Name = "10/2/2017",
                Start = new DateTime(1, 1, 1, 1, 30, 45),
                End = new DateTime(1, 1, 1, 5,45,45),
                //PercentComplete = 75
            };
            var start1 = new
            {
                Name = "11/2/2017",
                Start = new DateTime(1, 1, 1, 0, 30, 45),
                End = new DateTime(1, 1, 1, 15, 45, 45),
                //PercentComplete = 75
            };

            Chart1.ChartAreas[0].BackColor = System.Drawing.Color.Transparent;
            Chart1.ChartAreas[0].Position.Height = 100;
            Chart1.ChartAreas[0].Position.Width = 100;
            Chart1.ChartAreas[0].InnerPlotPosition.Height = 90;
            Chart1.ChartAreas[0].InnerPlotPosition.Width = 80;
            Chart1.ChartAreas[0].InnerPlotPosition.X = 10;
            DateTime minDate = new DateTime(1, 1, 1, 0, 0, 0);
            DateTime maxDate = new DateTime(1, 1, 1, 23, 59, 59);
            Chart1.ChartAreas[0].AxisY.Minimum = minDate.ToOADate();
            Chart1.ChartAreas[0].AxisY.Maximum = maxDate.ToOADate();
            Chart1.ChartAreas[0].AxisY.LabelStyle.Angle = 0;// TextOrientation = System.Web.UI.DataVisualization.Charting.TextOrientation.Stacked;
            Chart1.ChartAreas[0].AxisY.Interval = 1;
            Chart1.ChartAreas[0].AxisY.IntervalType = System.Web.UI.DataVisualization.Charting.DateTimeIntervalType.Hours;
            //Chart1.ChartAreas[0].AxisY.Interval = 1;
            //DateTime minTime = new 
            //DateTime.Now.Date.ToString();
            Chart1.Series["Uptime"].Points.AddXY(start.Name,start.Start, start.End);
            Chart1.Series["Uptime"].Points.AddXY(start1.Name, start1.Start, start1.End);
            //Chart1.ChartAreas[0].AxisY.Minimum = 0;
            //Chart1.ChartAreas[0].AxisY.Maximum = 24;
            
        }
    }
}