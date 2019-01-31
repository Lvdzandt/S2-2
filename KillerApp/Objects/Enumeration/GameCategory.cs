using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Objects.Enumeration
{
    public class GameCategory
    {
        public enum Categorie
        {
            [Display(Name = "Any")]
            [Description("Any")]
            Any,
            [Display(Name = "100%")]
            [Description("100")]
            OneHundred,
            [Display(Name = "200%")]
            [Description("200")]
            TwoHundred

        }
    }
}
