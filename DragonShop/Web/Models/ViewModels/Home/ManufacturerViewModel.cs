using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.ViewModels
{
    public sealed class ManufacturerViewModel
    { 
        public string Name { get; set; }
        public IFile File { get; set; }

        public IEnumerable<TobaccoViewModel> Tobaccos { get; set; }
    }
}
