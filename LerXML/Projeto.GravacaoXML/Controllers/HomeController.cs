using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Projeto.GravacaoXML.Data;
using Projeto.GravacaoXML.Dto;
using Projeto.GravacaoXML.Models;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(RevistaDTO));
                StreamReader sr = new StreamReader(file);
                RevistaDTO revistaDTO = (RevistaDTO)xmlSerializer.Deserialize(sr);

                Revista dados = Revista.Adapter(revistaDTO);


                foreach (var processo in dados.Processos)
                {
                    if (processo.ClasseNice != null)
                    {
                        _context.CLASSENICE.Add(processo.ClasseNice);
                    }

                    if (processo.Marca != null)
                        _context.MARCA.Add(processo.Marca);

                    if (processo.ClassesVienna != null)
                    {
                        if (processo.ClassesVienna.ClasseVienna != null)
                        {
                            foreach (var classeVienna in processo.ClassesVienna.ClasseVienna)
                            {
                                _context.CLASSEVIENNA.Add(classeVienna);
                            }
                        }
                        _context.CLASSESVIENNA.Add(processo.ClassesVienna);
                    }

                    if (processo.Despachos != null)
                    {
                        foreach (var despacho in processo.Despachos)
                        {
                            _context.DESPACHO.Add(despacho);
                        }
                    }

                    if (processo.Titulares != null)
                    {
                        foreach (var titular in processo.Titulares)
                        {
                            _context.TITULAR.Add(titular);
                        }
                    }
                }

                _context.REVISTA.Add(dados);
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
