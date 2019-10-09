using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Projeto.GravacaoXML.Data;
using Projeto.GravacaoXML.Dto;
using Projeto.GravacaoXML.Models;

namespace Projeto.GravacaoXML.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _context;
        private IHostingEnvironment _env;

        public HomeController(ApplicationDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }



        public async Task<IActionResult> Index()
        {

            try
            {
                var webRoot = _env.WebRootPath;
                var file = System.IO.Path.Combine(webRoot, @"xml\2323.xml");

               // XmlSerializer xmlSerializer = new XmlSerializer(typeof(RevistaDTO));
               // StreamReader sr = new StreamReader(file);
               //// var revista = xmlSerializer.Deserialize(sr);
               // RevistaDTO DadosLidos = (RevistaDTO)xmlSerializer.Deserialize(sr);

                //Revista dados = Revista.Adapter(DadosLidos);
                //dados.Data = DadosLidos.Data;
                //dados.Numero = DadosLidos.Numero;
               // _context.REVISTA.Add(dados);
                //_context.Add(dados);
                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
