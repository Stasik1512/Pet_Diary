using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pet_Diary
{
     public class Query
    {
        private readonly DataBase dataBase;

        public Query(DataBase dataBase)
        {
            this.dataBase = dataBase;
        }
        public DataTable GetAllOwners()     // получение
        {
            string query = @"
                SELECT owner_id, owner_name, phone, email
                FROM Owners
                ORDER BY owner_name";
            return dataBase.ExecuteQuery(query);
        }
        public int AddOwner(string ownerName, string phone, string email)  //добавление
        {
            string query = @"
                INSERT INTO Owners(owner_name, phone, email)
                VALUES(@owner_name, @phone, @email)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@owner_name", ownerName),
                new SqlParameter("@phone", phone),
                new SqlParameter("@email", email)
            };
            return dataBase.ExecuteNonQuery(query, parameters);
        }
        public int DeleteOwner(short ownerId)  // удаление
        {
            string query = @"
                DELETE FROM Owners
                WHERE owner_id = @owner_id";
            SqlParameter parameter =
                new SqlParameter("@owner_id", ownerId);
            return dataBase.ExecuteNonQuery(query, parameter);
        }

        public int UpdateOwner(short ownerId,string ownerName, string phone, string email) // обновление
        {
            string query = @"
            UPDATE Owners
            SET owner_name = @owner_name,
            phone = @photo,
            email = @email
            WHERE owner_id = @owner_id";
            SqlParameter[] parameters =
            {
            new SqlParameter("@owner_id", ownerId),
            new SqlParameter("@owner_name", ownerName),
            new SqlParameter("@phone", phone),
            new SqlParameter("@email", email)
            };

            return dataBase.ExecuteNonQuery(query,parameters);
        }


        ////////////////////////////////////////////////////////////////////////////////////////
        public DataTable GetAllPets()
        {
            string query = @"
            SELECT pet_id, pet_name, pet_breed, pet_gender, pet_photo, pet_birth, owner_id
            FROM Pets 
            ORDER BY pet_name";

            return dataBase.ExecuteQuery(query);
        }
        public int AddPet(string petName, string petBreed, string petGender, string petPhoto, DateTime petBirth, short ownerId)
        {
            string query = @"
            INSERT INTO Pets(pet_name, pet_breed, pet_gender, pet_photo, pet_birth, owner_id)
            VALUES (@pet_name, @pet_breed, @pet_gender, @pet_photo, @pet_birth, @owner_id)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@pet_name", petName),
                new SqlParameter("@pet_breed", petBreed),
                new SqlParameter("@pet_gender", petGender),
                new SqlParameter("@pet_photo", petPhoto),
                new SqlParameter("@pet_birth", petBirth),
                new SqlParameter("@owner_id", ownerId)
            };

            return dataBase.ExecuteNonQuery(query, parameters);
        }
         public int UpdatePet(short petId, string petName, string petBreed, string petGender, string petPhoto, DateTime petBirth, string ownerId)
        {
            string query = @"
            UPDATE Pets
            SET pet_name = @pet_name,
            pet_breed = @pet_breed,
            pet_gender = @pet_gender,
            pet_photo = @pet_photo,
            pet_birth = @pet_birth
            owner_id = @owner_id
            WHERE pet_id = @pet_id";

            SqlParameter[] parameters =
            {
                new SqlParameter("@pet_id", petId),
                new SqlParameter("@pet_name", petName),
                new SqlParameter("@pet_breed", petBreed),
                new SqlParameter("@pet_gender", petGender),
                new SqlParameter("@pet_photo", petPhoto),
                new SqlParameter("@pet_Birth", petBirth),    
                new SqlParameter("@owner_id", ownerId)
            };
            return dataBase.ExecuteNonQuery(query,parameters);
        }

        public int DeletePet(short petId)
        {
            string query = @"
            DELETE FROM Pets
            WHERE pet_id = @pet_id";

            SqlParameter parameter = new SqlParameter("@pet_id", petId);

            return dataBase.ExecuteNonQuery(query, parameter);
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public DataTable GetPetsByOwner(short ownerId)
        {
            string query = @"
            SELECT pet_id, pet_name, pet_breed
            FROM Pets
            WHERE owner = @owner_id
            ORDER BY pet_name";
            SqlParameter parameter = new SqlParameter("@owner_id", ownerId);
            return dataBase.ExecuteQuery(query, parameter);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public int AddPet
        (
            string petName,
            string petBreed,
            string petGender,
            DateTime petBirth,
            short ownerId
        )
        {
            string query = @"
            INSERT INTO Pets(pet_name, pet_breed, pet_gender, pet_birth, owner)
            VALUES(@pet_name, @pet_breed, @pet_gender, @pet_birth, @owner)";

            SqlParameter[] parameter =
            {
                new SqlParameter("@pet_name", petName),
                new SqlParameter("@pet_breed", petBreed),
                new SqlParameter("@pet_gender", petGender),
                new SqlParameter("@pet_birth", petBirth),
                new SqlParameter("@owner", ownerId)
            };

            return dataBase.ExecuteNonQuery (query, parameter);
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////

     }
}