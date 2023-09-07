using SalesFunil.desktop.Views;
using System.Security.Cryptography.X509Certificates;

namespace SalesFunil.desktop {

    public partial class PetView : Form, IPetView {

        #region Atributos
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        #endregion

        #region Propriedades IPetView
        public string PetId {
            get => this.txtPetID.Text;
            set => this.txtPetID.Text = value;
        }

        public string PetName {
            get => this.txtPetName.Text;
            set => this.txtPetName.Text = value;
        }

        public string PetType {
            get => this.txtPetType.Text;
            set => this.txtPetType.Text = value;
        }

        public string PetColour {
            get => this.txtPetColour.Text;
            set => this.txtPetColour.Text = value;
        }

        public string SearchValue {
            get => this.txtSearch.Text;
            set => this.txtSearch.Text = value;
        }

        public bool IsEdit {
            get => this.isEdit;
            set => this.isEdit = value;
        }

        public bool IsSuccessful {
            get => this.isSuccessful;
            set => this.IsSuccessful = value;
        }

        public string Message {
            get => this.message;
            set => this.message = value;
        }
        #endregion

        #region Eventos IPetView
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        #endregion

        #region Construtor
        public PetView() {

            this.InitializeComponent();
            this.associateAndRaiseViewEvents();
            this.tabControlPets.TabPages.Remove(this.tbpPetDetail);

        }
        #endregion

        #region Métodos IPetView
        public void SetPetListBindingSource(BindingSource petList) {
            this.dgvPetList.DataSource = petList;
        }
        #endregion

        #region Métodos
        private void associateAndRaiseViewEvents() {
            //Contravariância de delegações
            this.btnSearch.Click += delegate {
                this.SearchEvent?.Invoke(sender: this,
                                         e: EventArgs.Empty);
            };

            this.txtSearch.KeyDown += (sender, keyEventArgs) => {
                if (keyEventArgs.KeyCode == Keys.Enter) {
                    this.SearchEvent?.Invoke(sender: this,
                                             e: EventArgs.Empty);
                }
            };

        }

        #endregion

    }
}