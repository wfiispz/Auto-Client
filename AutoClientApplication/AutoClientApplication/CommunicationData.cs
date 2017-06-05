using System.Collections.Generic;

namespace AutoClientApplication {

    class ResourcesRespond {
        public List<Resources> resources;
        public Page page;
    }

    class Resources {
        public string id;
        public string name;
        public string description;
        public List<string> measurements;
    }

    class Page {
        public int size;
        public int number;
        public int totalCount;
    }

}
