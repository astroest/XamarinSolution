using System;
using System.Collections.Generic;
using System.Text;
using Entty = Microcharts.ChartEntry;
using SkiaSharp;

namespace ONEUL.ViewModel
{
    class ReportPageViewModel
    {
        List<Microcharts.ChartEntry> entries = new List<Microcharts.ChartEntry>
        {
            new Microcharts.ChartEntry(200)
            {
                Color = SKColor.Parse("#E88346"),
                Label = "Study",
                ValueLabel = "200"
            },
            new Microcharts.ChartEntry(100)
            {
                Color = SKColor.Parse("#E88346"),
                Label = "Exercise",
                ValueLabel = "100"
            },
            new Microcharts.ChartEntry(150)
            {
                Color = SKColor.Parse("#E88346"),
                Label = "Lecture",
                ValueLabel = "150"
            }
        };
    }
}
