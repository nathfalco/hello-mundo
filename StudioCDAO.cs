using StudioC.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace StudioC.Services
{
    public class StudioCDAO
    {
        public SQLiteConnection conexao;

        public StudioCDAO()
        {
            string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Usuario.db3");
            var db = new SQLiteConnection(dpPath);
            conexao = new SQLiteConnection(dpPath);
            db.CreateTable<StudioCC>();
        }
        public List<StudioCC> GetTodos()
        {
            return (from data in conexao.Table<StudioCC>()
                    select data).ToList();
        }

        public StudioCC Get(int id)
        {
            return conexao.Table<StudioCC>().FirstOrDefault(t => t.Id == id);
        }
        public StudioCC Get(string Nome)
        {
            return conexao.Table<StudioCC>().FirstOrDefault(t => t.Nome == Nome);
        }
       

        public void Adicionar(StudioCC studio)
        {
            conexao.Insert(studio);
        }
        public void Encontrar(StudioCC studio)
        {
            conexao.Get<StudioCC>(studio);
        }
    }
}
