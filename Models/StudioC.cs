using SQLite;
using System;

namespace StudioC.Models
{
    public class StudioCC
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Senha { get; set; }

        public string Telefone { get; set; }


        public override bool Equals(object obj)
        {
            var studio = obj as StudioCC;
            if (studio == null)
            {
                return false;
            }

            return Id.Equals(studio.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public bool Contains(String texto)
        {
            return Nome.ToLower().Contains(texto.ToLower()) || Senha.ToLower().Contains(texto.ToLower()) || Telefone.ToLower().Contains(texto.ToLower());
        }
    }
}
