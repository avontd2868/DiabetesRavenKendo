using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DiabetesRavenKendo.Models;

namespace DiabetesRavenKendo.ViewModels
{
    public class DiabetesLogEntryViewModel
    {
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public IEnumerable<InsulinDosageModel> InsulinDosages { get; set; }
        public IEnumerable<FoodItemModel> FoodItems { get; set; }
        public GlucoseReadingModel GlucoseReading { get; set; }
        public string Comments { get; set; }
    }
}