using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);
            //これは確認用
            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var xelement = xdoc.Root.Elements()
                                    .Select(x => new {
                                        Name = (string)x.Element("name"),
                                        Teammembers = (string)x.Element("teammembers")
                                    });
            foreach (var xsample in xelement) {
                Console.WriteLine("{0} {1}", xsample.Name, xsample.Teammembers);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var xelement = xdoc.Root.Elements()
                                    .Select(x => new {
                                        Name = (string)x.Element("name").Attribute("kanji"),
                                        Firstplayed = (string)x.Element("firstplayed")
                                    }).OrderBy(x => x.Firstplayed);
            foreach (var xsample in xelement) {
                Console.WriteLine("{0}({1})", xsample.Name, xsample.Firstplayed);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            #region
            //var xteammembers = xdoc.Root.Elements()
            //                        .Select(x => new {
            //                            Teammembers = (string)x.Element("teammembers")
            //                        }).Max(x => x.Teammembers);

            //var xname = xdoc.Root.Elements()
            //                        .Where(x => x.Element("teammembers").Value == xteammembers);

            //foreach (var sport in xname) {
            //    Console.WriteLine(sport.Element("name").Value);
            //}
            #endregion
            var sport = xdoc.Root.Elements()
                            .Select(x => new {
                                Name = x.Element("name").Value,
                                Teammembers = x.Element("teammembers").Value
                            })
                            .OrderByDescending(x => int.Parse(x.Teammembers)).FirstOrDefault();

            Console.WriteLine("{0}({1}人)", sport.Name, sport.Teammembers);
        }

        private static void Exercise1_4(string file, string newfile) {
            var xdoc = XDocument.Load(file);

            //要素の追加
            var element = new XElement("ballsport",
                                        new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                                        new XElement("teammembers", "11"),
                                        new XElement("firstplayed", "1863")
                                       );

            xdoc.Root.Add(element);

            //XMLファイルへの保存
            xdoc.Save(newfile);
        }
    }
}
