
namespace CW_ADB_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class View_AllOperations
    {
		[Key]
		[Display(Name = "Номер операции")]
        public int OperationID { get; set; }
        [Display(Name = "Номер топлива")]
        public Nullable<int> FuelID { get; set; }
        [Display(Name = "Номер емкости")]
        public Nullable<int> TankID { get; set; }
        [Display(Name = "Приход/Расход")]
        public Nullable<float> Inc_Exp { get; set; }
        [Display(Name = "Дата операции")]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> Date { get; set; }
        [Display(Name = "Топливо")]
        public string FuelType { get; set; }
        [Display(Name = "Емкость")]
        public string TankType { get; set; }
    }
}
