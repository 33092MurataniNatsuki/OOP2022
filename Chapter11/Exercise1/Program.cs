﻿using System;
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
            var xelement = xdoc.Root.Elements()
                                    .Select(x => new {
                                        Name = (string)x.Element("name"),
                                        Teammembers = (string)x.Element("teammembers")
                                    }).Max(x => x.Teammembers);
            Console.WriteLine(xelement);
        }

        private static void Exercise1_4(string file, string newfile) {
            var element = new XElement("ballsport",
                                        new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                                        new XElement("teammembers", "11"),
                                        new XElement("firstplayed", "1848")
                                       );
            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(element);
        }
    }
}
