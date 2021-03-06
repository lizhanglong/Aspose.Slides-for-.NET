﻿using Aspose.Slides.Charts;
using Aspose.Slides.Export;
using Aspose.Slides;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Slides for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Slides for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Slides.Examples.CSharp.Charts
{
    public class SetChartSeriesOverlap
    {
        public static void Run()
        {
            //ExStart:SetChartSeriesOverlap
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Charts();

            using (Presentation presentation = new Presentation())
            {
                // Adding chart
                IChart chart = presentation.Slides[0].Shapes.AddChart(ChartType.ClusteredColumn, 50, 50, 600, 400, true);
                IChartSeriesCollection series = chart.ChartData.Series;
                if (series[0].Overlap == 0)
                {
                    // Setting series overlap
                    series[0].ParentSeriesGroup.Overlap = -30;
                }

                // Write the presentation file to disk
                presentation.Save(dataDir + "SetChartSeriesOverlap_out.pptx", SaveFormat.Pptx);
            }
            //ExEnd:SetChartSeriesOverlap
        }
    }
}