using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesFunil.desktop.Views {
    public interface IPetView {

        #region Propriedades
        public string PetId { get; set; } 
        public string PetName { get; set; }
        public string PetType { get; set; }
        public string PetColour {get; set; }
        
        public string SearchValue { get; set; }
        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get;set; }
        #endregion

        #region Eventos
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        #endregion

        #region Métodos

        public void SetPetListBindingSource(BindingSource petList);
        public void Show();

        #endregion


    }
}
