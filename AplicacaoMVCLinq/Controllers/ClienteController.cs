using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult GetClientes()
        {
            Cliente c1 = new Cliente(1, "Livia Modesto Ormeleze", "lormeleze@gmail.com", "1234-5678", new DateOnly(2007, 11, 27));

            Cliente c2 = new Cliente(2, "Gabriela Siqueira Caputti", "bibibis@gmail.com\"", "8765-4321", new DateOnly(2008, 3, 16));

            Cliente c3 = new Cliente(3, "Ana Clara de Souza", "aninhafedida@gmail.com", "2143-6587", new DateOnly(2007, 8, 3));

            Cliente c4 = new Cliente(4, "Bryan Martins Fusco", "ratinquerqueijo@gmail.com", "5678-1234", new DateOnly(2007, 8, 9));

            Cliente c5 = new Cliente(5, "João Pedro Milani", "jpobrabo@gmail.com", "1827-3645", new DateOnly(2007, 6, 2));

            //Criar uma lista de Alunos
            List<Cliente> ListaClientes = new List<Cliente>();
            //Adicionar os Objetos Alunos na Lista Alunos 
            ListaClientes.Add(c1);
            ListaClientes.Add(c2);
            ListaClientes.Add(c3);
            ListaClientes.Add(c4);
            ListaClientes.Add(c5);

            //Enviando a lista de Aunos por parametro na View Index
            return View(ListaClientes);
        }
    }
}
