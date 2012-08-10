using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Web.Mvc;
using System.Web.Security;

namespace DiabetesRavenKendo.Models
{
    public enum GluscoseStickLocationEnum
    {
        L1,
        L2,
        L3,
        L4,
        R1,
        R2,
        R3,
        R4,
        NA
    }

    public class GlucoseReadingModel : RavenBaseModel
    {
        public string Glucose { get; set; }
        public GluscoseStickLocationEnum Location { get; set;}
    }

    public enum InsulinEnum
    {
        Novalog,
        Lantus,
        NA
    }

    public class InsulinDosageModel
    {
        public decimal Units { get; set; }
        public InsulinEnum InsulinType { get; set; }
        public string InjectionLocation { get; set; }
    }

    public class FoodItemModel
    {
        public decimal Carbs { get; set; }
        public string Food { get; set; }
    }

    public class DiabetesLogEntryModel : RavenBaseModel
    {
        public DiabetesLogEntryModel()
        {
            InsulinDosages = new List<InsulinDosageModel>();
            FoodItems = new List<FoodItemModel>();
            GlucoseReading = new GlucoseReadingModel() { Location = GluscoseStickLocationEnum.NA };
        }

        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public IEnumerable<InsulinDosageModel> InsulinDosages { get; set; }
        public IEnumerable<FoodItemModel> FoodItems { get; set;}
        public GlucoseReadingModel GlucoseReading { get; set; }
        public string Comments { get; set; }
    }

    public class RavenBaseModel
    {
        public int Id { get; set; }
    }

}