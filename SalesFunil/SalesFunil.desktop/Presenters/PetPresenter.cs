using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesFunil.desktop.Models;
using SalesFunil.desktop.Views;
using System.Windows.Forms;

namespace SalesFunil.desktop.Presenters {

    public class PetPresenter {

        #region Atributos
        private IPetView _petView;
        private IPetRepository _petRepository;
        private BindingSource _petBindingSource;
        private IEnumerable<PetModel> _petList;

        #endregion

        #region Construtor
        public PetPresenter(IPetView petView, 
                            IPetRepository petRepository) {
            
            this._petView = petView;
            this._petRepository = petRepository;
            this._petBindingSource = new BindingSource();

            //Sobrescreve os eventos de manipulação para a view.
            this._petView.SearchEvent += searchPet;
            this._petView.AddNewEvent += addNewPet;
            this._petView.EditEvent += loadSelectedPetToEdit;
            this._petView.DeleteEvent += deleteSelectedPet;
            this._petView.SaveEvent += savePet;
            this._petView.CancelEvent += cancelAction;

            //
            this._petView.SetPetListBindingSource(this._petBindingSource);
            //
            this.loadAllPetList();
            //
            this._petView.Show();
        }
        #endregion

        #region Métodos
        private void searchPet(object sender, EventArgs e) {
            bool emptyValue = string.IsNullOrEmpty(this._petView.SearchValue);
            if (!emptyValue) {
                this._petList = this._petRepository.GetByValue(value: this._petView.SearchValue);
            }
            else {
                this._petList = this._petRepository.GetAll();
            }
            this._petBindingSource.DataSource = this._petList;
        }
        private void cancelAction(object? sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void savePet(object? sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void deleteSelectedPet(object? sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void loadSelectedPetToEdit(object? sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void addNewPet(object? sender, EventArgs e) {
            throw new NotImplementedException();
        }

        private void loadAllPetList() {
            this._petList = this._petRepository.GetAll();
            this._petBindingSource.DataSource = this._petList;
        }

        #endregion

    }

}
