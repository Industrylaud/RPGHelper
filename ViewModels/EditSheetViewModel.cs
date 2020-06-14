using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGHelper.ViewModels
{
    public class EditSheetViewModel : CreateSheetViewModel
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
    }
}
