using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEBAPIValidation.API.Models.DTO
{
    public class NinjaDTO
    {
        [Required(ErrorMessage ="Ninja ismi boş geçilemez")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Ninja ünvanı boş geçilemez")]
        public string Title { get; set; }

        [EmailAddress(ErrorMessage ="EMail formatına uygun değil")]
        [Required(ErrorMessage ="Ninja email adresi boş geçilemez")]
        public string EMail { get; set; }
    }
}