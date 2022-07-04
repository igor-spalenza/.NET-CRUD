using System.Collections.Generic;
using System.Data.Entity;
using Treinamento_CRM_Educacional.Models;

namespace Treinamento_CRM_Educacional.Data
{
    internal class DbInitializer : CreateDatabaseIfNotExists<TreinamentoDataContext>
    {
        protected override void Seed(TreinamentoDataContext context)
        {
            var pessoas = new List<Pessoa>() {
                new Pessoa() { Cpf= "11487057679", Nome="Igor", Email="igor.spalenza94@gmail.com", Telefone= "31975092916", Cep= "31742302"},
                new Pessoa() { Cpf= "81436807700", Nome="Sandra", Email="spalenzabuffet@gmail.com", Telefone= "31991385533", Cep= "31742302"}
            };

            context.Pessoas.AddRange(pessoas);

            context.SaveChanges();
        }
    }
}