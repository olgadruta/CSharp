using System.ComponentModel.DataAnnotations;
namespace DojoSurveyValidation.Models

{
    public class Survey 
    {
        [Required ]
        [MinLength(2)]
        public string Name{get;set;}

        [Required ]
        public string location{get;set;}

        [Required ]
        public string language{get;set;}

        [MinLength(20)]
        public string comment{get;set;}
    }
}