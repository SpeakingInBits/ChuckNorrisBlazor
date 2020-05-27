using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckNorrisBlazor.Shared
{

    public class ChuckNorrisResponse
    {
        public string Type { get; set; }

        public SingleJoke Value { get; set; }
    }

    public class SingleJoke
    {
        public int Id { get; set; }

        public string Joke { get; set; }

        public string[] Categories { get; set; }
    }

}
