using _0318.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0318.Services
{
    public class ImportXmlService
    {
        public int count;
        public ImportXmlService() { }
        public List<Activity> LoadFormFile(string filePath)
        {
            var str = System.IO.File.ReadAllText(filePath);

            var xDocument = System.Xml.Linq.XDocument.Parse(str);

            var targets = xDocument.Descendants("Activity");

            return targets
                .Select(x =>
                { 
                    var item = new Activity();
                    item.Name = x.Element("Name").Value;
                    item.End = x.Element("End").Value;
                    item.Start = x.Element("Start").Value;
                    item.End = x.Element("End").Value;
                    return item;
                })
                .ToList();
        }
    }
}
