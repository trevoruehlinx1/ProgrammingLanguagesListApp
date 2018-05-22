using System;
using System.Collections.Generic;
namespace ProgrammingLanguagesApp
{
    public class ProgrammingLanguage
    {
        public ProgrammingLanguage()
        {
        }

        public string Name { get; set; }

        public string Date { get; set; }

        public string ChiefDevs { get; set; }

        public string InfluencedBy { get; set; }

        public static List<ProgrammingLanguage> LanguageList = new List<ProgrammingLanguage>() {
            new ProgrammingLanguage {
                Name = "C",
                Date = "1972",
                ChiefDevs = "Dennis Ritchie",
                InfluencedBy = "B, BCPL, ALGOL 68"
            },
            new ProgrammingLanguage {
                Name = "Fortran",
                Date = "1954",
                ChiefDevs = "John W. Backus",
                InfluencedBy = "Speedcoding"
            },
            new ProgrammingLanguage{ Name = "LISP", Date = "1956", ChiefDevs = "John McCarthy", InfluencedBy = "IPL" },
            new ProgrammingLanguage {
                Name = "COBOL",
                Date = "1959",
                ChiefDevs = "The CODASYL Committee",
                InfluencedBy = "FLOW-MATIC, COMTRAN, FACT"
            },
            new ProgrammingLanguage {
                Name = "FACT",
                Date = "1959",
                ChiefDevs = "Fletcher R. Jones, Roy Nutt, Robert L. Patrick",
                InfluencedBy = "None"
            },
            new ProgrammingLanguage{ Name = "TRAC", Date = "1959", ChiefDevs = "Calvin Mooers", InfluencedBy = "None" },
            new ProgrammingLanguage {
                Name = "APL",
                Date = "1962",
                ChiefDevs = "Kenneth E. Iverson",
                InfluencedBy = "None"
            },
            new ProgrammingLanguage {
                Name = "BASIC",
                Date = "1964",
                ChiefDevs = "John George Kemeny and Thomas Eugene Kurtz",
                InfluencedBy = "FORTRAN II, JOSS"
            },
            new ProgrammingLanguage {
                Name = "InterLisp",
                Date = "1967",
                ChiefDevs = "D.G. Bobrow and D.L. Murphy",
                InfluencedBy = "LISP"
            },
            new ProgrammingLanguage {
                Name = "B",
                Date = "1969",
                ChiefDevs = "Ken Thompson, with contributions from Dennis Ritchie",
                InfluencedBy = "BCPL"
            },
            new ProgrammingLanguage {
                Name = "Pascal",
                Date = "1970",
                ChiefDevs = "Niklaus Wirth, Kathleen Jensen",
                InfluencedBy = "ALGOL 60, ALGOL W"
            },
            new ProgrammingLanguage {
                Name = "APL",
                Date = "1962",
                ChiefDevs = "Kenneth E. Iverson",
                InfluencedBy = "None"
            },
            new ProgrammingLanguage {
                Name = "SNOBOL",
                Date = "1962",
                ChiefDevs = "Griswold",
                InfluencedBy = "FORTRAN II, COMIT"
            },
            new ProgrammingLanguage {
                Name = "MIMIC",
                Date = "1964",
                ChiefDevs = "H. E. Petersen",
                InfluencedBy = "MIDAS"
            },
            new ProgrammingLanguage{ Name = "IBM RPH", Date = "1964", ChiefDevs = "IBM", InfluencedBy = "FARGO" },
            new ProgrammingLanguage {
                Name = "ISWIM",
                Date = "1966",
                ChiefDevs = "Peter J. Landin",
                InfluencedBy = "LISP"
            },
            new ProgrammingLanguage{ Name = "Forth", Date = "1968", ChiefDevs = "Moore", InfluencedBy = "None" },
            new ProgrammingLanguage{ Name = "LOGO", Date = "1968", ChiefDevs = "Seymour Papert", InfluencedBy = "LISP" },
            new ProgrammingLanguage {
                Name = "PILOT",
                Date = "1968",
                ChiefDevs = "John Amsden Starkweather, University of California, San Francisco",
                InfluencedBy = "Computest"
            },
            new ProgrammingLanguage {
                Name = "BLISS",
                Date = "1970",
                ChiefDevs = "Wulf, Russell, Habermann",
                InfluencedBy = "ALGOL"
            },
            new ProgrammingLanguage {
                Name = "Smalltalk",
                Date = "1972",
                ChiefDevs = "Daniel Henry Holmes Ingalls, Jr., Xerox PARC",
                InfluencedBy = "Simula 67"
            },
            new ProgrammingLanguage {
                Name = "PL/M",
                Date = "1972",
                ChiefDevs = "Gary Kildall",
                InfluencedBy = "PL/I, ALGOL, XPL"
            },
            new ProgrammingLanguage {
                Name = "INTERCAL",
                Date = "1972",
                ChiefDevs = "Don Woods and James M. Lyon",
                InfluencedBy = "None"
            },
            new ProgrammingLanguage {
                Name = "Prolog",
                Date = "1972",
                ChiefDevs = "Alain Colmerauer",
                InfluencedBy = "2-level W-Grammar"
            },
            new ProgrammingLanguage {
                Name = "COMAL",
                Date = "1973",
                ChiefDevs = "Børge Christensen, Benedict Løfstedt",
                InfluencedBy = "Pascal, BASIC"
            },
            new ProgrammingLanguage {
                Name = "GRASS",
                Date = "1974",
                ChiefDevs = "Thomas A. DeFanti",
                InfluencedBy = "BASIC"
            },
            new ProgrammingLanguage {
                Name = "ABC",
                Date = "1975",
                ChiefDevs = "Leo Geurts and Lambert Meertens",
                InfluencedBy = "SETL"
            },
            new ProgrammingLanguage {
                Name = "Scheme",
                Date = "1975",
                ChiefDevs = "Gerald Jay Sussman, Guy L. Steele, Jr.",
                InfluencedBy = "LISP"
            },
            new ProgrammingLanguage {
                Name = "Altair BASIC",
                Date = "1975",
                ChiefDevs = "Bill Gates, Paul Allen",
                InfluencedBy = "BASIC"
            },
            new ProgrammingLanguage {
                Name = "Modula",
                Date = "1975",
                ChiefDevs = "Niklaus Wirth",
                InfluencedBy = "Pascal"
            },
            new ProgrammingLanguage {
                Name = "Ratfor",
                Date = "1976",
                ChiefDevs = "Brian Kernighan",
                InfluencedBy = "C, FORTRAN"
            },
            new ProgrammingLanguage {
                Name = "Bourne Shell (sh)",
                Date = "1977",
                ChiefDevs = "Stephen R. Bourne",
                InfluencedBy = "None"
            },
            new ProgrammingLanguage {
                Name = "MATLAB",
                Date = "1978",
                ChiefDevs = "Cleve Moler",
                InfluencedBy = "Fortran"
            },
            new ProgrammingLanguage {
                Name = "CBASIC",
                Date = "1980",
                ChiefDevs = "Gordon Eubanks",
                InfluencedBy = "BASIC, Compiler Systems, Digital Research"
            },
            new ProgrammingLanguage {
                Name = "PostScript",
                Date = "1982",
                ChiefDevs = "Warnock",
                InfluencedBy = "InterPress"
            },
            new ProgrammingLanguage {
                Name = "Objective-C",
                Date = "1983",
                ChiefDevs = "Brad Cox",
                InfluencedBy = "Smalltalk, C"
            },
            new ProgrammingLanguage {
                Name = "C++",
                Date = "1983",
                ChiefDevs = "Bjarne Stroustrup",
                InfluencedBy = "C with Classes"
            },
            new ProgrammingLanguage {
                Name = "Korn Shell (ksh)",
                Date = "1983",
                ChiefDevs = "David Korn",
                InfluencedBy = "sh"
            },
            new ProgrammingLanguage {
                Name = "Perl",
                Date = "1987",
                ChiefDevs = "Larry Wall",
                InfluencedBy = "C, sed, awk, sh"
            },
            new ProgrammingLanguage {
                Name = "Bash",
                Date = "1989",
                ChiefDevs = "Brian Fox",
                InfluencedBy = "Bourne Shell, C Shell, Korn Shell"
            },
            new ProgrammingLanguage {
                Name = "AMPL",
                Date = "1990",
                ChiefDevs = "Robert Fourer, David Gay and Brian Kernighan",
                InfluencedBy = "None"
            },
            new ProgrammingLanguage{ Name = "Haskell", Date = "1990", ChiefDevs = "Unknown", InfluencedBy = "Miranda" },
            new ProgrammingLanguage {
                Name = "Python",
                Date = "1991",
                ChiefDevs = "Guido van Rossum",
                InfluencedBy = "ABC, ALGOL 68, Icon, Modula-3"
            },
            new ProgrammingLanguage {
                Name = "Visual Basic",
                Date = "1991",
                ChiefDevs = "Alan Cooper",
                InfluencedBy = "QuickBASIC"
            },
            new ProgrammingLanguage {
                Name = "Brainfuck",
                Date = "1993",
                ChiefDevs = "Urban Müller",
                InfluencedBy = "P′′"
            },
            new ProgrammingLanguage {
                Name = "Lua",
                Date = "1993",
                ChiefDevs = "Roberto Ierusalimschy et al. at Tecgraf, PUC-Rio",
                InfluencedBy = "Scheme, SNOBOL, Modula, CLU, C++"
            },
            new ProgrammingLanguage {
                Name = "ColdFusion (CFML)",
                Date = "1995",
                ChiefDevs = "Allaire",
                InfluencedBy = "None"
            },
            new ProgrammingLanguage {
                Name = "Java",
                Date = "1995",
                ChiefDevs = "James Godling",
                InfluencedBy = "C, Simula 67, C++, Smalltalk, Ada 83, Objective-C, Mesa"
            },
            new ProgrammingLanguage{ Name = "PHP", Date = "1995", ChiefDevs = "Rasmus Lerdorf", InfluencedBy = "Perl" },
            new ProgrammingLanguage {
                Name = "Ruby",
                Date = "1995",
                ChiefDevs = "Yukihiro Matsumoto",
                InfluencedBy = "Smalltalk, Perl"
            },
            new ProgrammingLanguage {
                Name = "JavaScript",
                Date = "1995",
                ChiefDevs = "Brendan Eich",
                InfluencedBy = "LiveScript"
            },
            new ProgrammingLanguage {
                Name = "C#",
                Date = "2000",
                ChiefDevs = "Anders Hejlsberg, Microsoft (ECMA)",
                InfluencedBy = "C, C++, Java, Delphi, Modula-2"
            },
            new ProgrammingLanguage {
                Name = "Scala",
                Date = "2003",
                ChiefDevs = "Martin Odersky",
                InfluencedBy = "Smalltalk, Java, Haskell, Standard ML, OCaml"
            },
            new ProgrammingLanguage {
                Name = "F#",
                Date = "2005",
                ChiefDevs = "Don Syme, Microsoft Research",
                InfluencedBy = "OCaml, C#, Haskell"
            },
            new ProgrammingLanguage {
                Name = "Clojure",
                Date = "2007",
                ChiefDevs = "Rich Hickey",
                InfluencedBy = "Lisp, ML, Haskell, Erlang"
            },
            new ProgrammingLanguage {
                Name = "Go",
                Date = "2009",
                ChiefDevs = "Google",
                InfluencedBy = "C, Oberon, Limbo, Smalltalk"
            },
            new ProgrammingLanguage {
                Name = "CoffeeScript",
                Date = "2009",
                ChiefDevs = "Jeremy Ashkenas",
                InfluencedBy = "JavaScript, Ruby, Python, Haskell"
            }
        };
    }
}
