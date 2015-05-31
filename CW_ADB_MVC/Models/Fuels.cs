
namespace CW_ADB_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Fuels
    {
        public Fuels()
        {
            this.Operations = new HashSet<Operations>();
        }
		[Key]
        [Display(Name = "Номер топлива")]
        public int FuelID { get; set; }

        [Display(Name = "Тип топлива")]
        public string FuelType { get; set; }

        [Display(Name = "Плотность")]
        public Nullable<float> FuelDensity { get; set; }
        public virtual ICollection<Operations> Operations { get; set; }
    }
}
