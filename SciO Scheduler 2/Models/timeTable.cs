using System.ComponentModel.DataAnnotations;

namespace SciO_Scheduler_2.Models
{
    public class timeTable
    {
        [Key]
        public string venue { get; set; }


        [Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime blockAStartTime { get; set; }
        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime blockAEndTime { get; set; }


        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime blockBStartTime { get; set; }
        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime blockBEndTime { get; set; }


        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime blockCStartTime { get; set; }
        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime blockCEndTime { get; set; }


        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime blockDStartTime { get; set; }
        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime blockDEndTime { get; set; }


        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime blockEStartTime { get; set; }
        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime blockEEndTime { get; set; }


        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime blockFStartTime { get; set; }
        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime blockFEndTime { get; set; }



        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime bridgesStartTime { get; set; }
        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime bridgesEndTime { get; set; }


        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime gravityVehicleStartTime { get; set; }
        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime gravityVehicleEndTime { get; set; }


        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime pingPongParachuteStartTime { get; set; }
        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime pingPongParachuteEndTime { get; set; }


        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime trajectoryStartTime { get; set; }
        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime trajectoryEndTime { get; set; }


        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime wrightStuffStartTime { get; set; }
        //[System.ComponentModel.DataAnnotations.Required]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime wrightStuffEndTime { get; set;}

    }
}
