namespace kartkowka1.classes{

    internal class Person{
        public string Name{get; set; }
        public string Surname{get; set; }
        public DateTime Birth{get; set; }
        public List<string> animals_names {get; set; }

        public string GetAnimalsNames(){
            return string.Join(", ", animals_names);
        }

    }
}