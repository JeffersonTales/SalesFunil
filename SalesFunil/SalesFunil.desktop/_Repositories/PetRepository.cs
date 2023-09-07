using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SalesFunil.desktop.Models;

namespace SalesFunil.desktop._Repositories {

    public class PetRepository : BaseRepository, IPetRepository {

        #region Construtor
        public PetRepository(string connectionString) {
            this.connectionString = connectionString;
        }
        #endregion

        #region Métodos
        public void Add(PetModel petModel) {
            throw new NotImplementedException();
        }

        public void Delete(PetModel petModel) {
            throw new NotImplementedException();
        }

        public void Edit(PetModel petModel) {
            throw new NotImplementedException();
        }

        public IEnumerable<PetModel> GetAll() {
            var petList = new List<PetModel>();
            using (var connection = new SqlConnection(this.connectionString))
            using (var command = new SqlCommand()) {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Pet ORDER BY Pet_Id DESC";
                using (var reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        var pet = new PetModel();
                        for (int i = 0; i < pet.GetType().GetProperties().Length; i++) {
                            pet.GetType().GetProperties()[i].SetValue(pet, reader[i]);
                        }
                        petList.Add(pet);
                    }
                }
            }
            return petList;
        }

        public IEnumerable<PetModel> GetByValue(string value) {
            
            var petList = new List<PetModel>();
            int petId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string petName = value;

            using (var connection = new SqlConnection(this.connectionString))
            using (var command = new SqlCommand()) {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM PET WHERE Pet_Id = @id OR Pet_Name LIKE @name+'%' ORDER BY Pet_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = petId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = petName;
                using (var reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        var pet = new PetModel();
                        for (int i = 0; i < pet.GetType().GetProperties().Length; i++) {
                            pet.GetType().GetProperties()[i].SetValue(pet, reader[i]);
                        }
                        petList.Add(pet);
                    }
                }
            }

            return petList;
        }
        #endregion
    }
}
