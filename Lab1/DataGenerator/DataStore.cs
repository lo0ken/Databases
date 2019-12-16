using System;
namespace Generator_v._2.Generators
{
    internal class DataStore
    {
        private static Random random = new Random();
        private static string[] firstNames = new string[]
        {
            "Dudley", "Marilee", "Gretchen", "Hank", "Rich", "Tena", "Sarah", "Mozelle",
            "Carlos", "Kacy", "Mechelle", "Loris", "Lajuana", "Mana", "Xiao", "Mabell",
            "Mi", "Zenaida", "Olimpia", "Don", "Rosy", "Vickie", "Socorro", "Tamisha",
            "Marcy", "Cammie", "Charlotte", "Bobbye", "Eldora", "Wilbert", "Bethel",
            "Elizbeth", "Lizeth", "Fred", "Logan", "Rob", "Cortez", "Maritza", "Jc",
            "Mila",  "Vernon", "Loreta", "Ardelia", "Dwana", "Eliz", "Roselia", "Simone",
            "Fredric", "Lincoln", "Mariah"
        };

        private static string[] lastNames = new string[]
        {
            "Oconnor", "Hobbs", "Christensen", "Giles", "Mullins", "Brooks", "Ross",
            "Roberson", "Mcmahon", "Briggs", "Cordova", "Benson", "Cisneros", "Mason",
            "Estes", "Ayala", "Gates", "Peterson", "Phelps", "Garza", "Moon", "Dunlap",
            "Lara", "Sanfor", "Mann", "Mueller", "Sellers", "Velazquez", "James", "Pollard",
            "Benton", "Logan", "Willis", "Velasquez", "Shepard", "Hester", "Mayer", "Conway",
            "Montes", "Aguirre", "Blake", "Mcdowell", "Yates", "Shah", "Yang", "Bray", "Cruz",
            "Patel", "Roy", "Wagne", "Novak", "Dodson", "Weeks", "Alexander", "Brock", "Gray",
            "Calderon", "Knapp", "Blevins", "Norman", "Tapia", "Sandoval", "Wells", "Warner",
            "Chang", "Kramer", "Horton", "Reeves", "Glass", "Rhodes", "Cooke", "Woodward",
            "Bailey", "Cervantes", "Grant", "Griffin", "Benitez", "Campos", "Lowe", "Riley",
            "Burton", "Galloway", "Mckay", "Saunders", "Underwood", "Dalton", "Andrews",
            "Chase", "Trevino", "Neal", "Shepherd", "Duffy", "Watts", "George", "Pope",
            "Petersen", "Kerr", "Harrison", "Clements", "Riddle"
        };

        private static string[] hotels = new string[]
        {
            "Crystal Lodge", "Cupids Choice International Singles", "Angel Nest", "Wawaloam Reservation Inc",
            "Chris Hicks", "Carolyn H.Bullock", "All Seasons Resort", "Econo Lodge-East Port", "Happy Days Campground",
            "Red Roof Inn-Milwaukee", "Foothills Inn", "Mountain Views Bed & Breakfast", "Dan Dee Cabins",
            "Village By The Sea", "Hanging Rock State Park", "Tumble Hill Campground", "Anaheim Online Hotel Group",
            "Stoneleigh Hotel & Spa", "Site Line", "Wildhurst Campgrounds", "Alan Stitzer", "Cendant Motel",
            "Museum Of The Southern Jewish", "Colorado Trails Ranch", "Hotel Elliott", "Amity Rose Bed & Breakfast",
            "Jessica Fore", "Camp Selah", "Eden Valley Guest Ranch", "Warwick Denver Hotel", "Hadlock Motel",
            "Darrah House", "Coney Island Usa", "Irelands Rustic Lodge", "Med-Net Information Management Group",
            "Vegas Hotel Casinos Online", "Mountain Inn & Suites", "Hummer House", "Don Trone", "Lakehill: Shelties Of Distinction",
            "Tower Motel", "Wooded Acres Campground", "Christopher J.Jalbert", "Best Western-Trl Ldge & Suites",
            "Bay Shore Inn", "Marion", "Courtyard-Alburquerque", "Gulf Stream Motel & Marina", "Friendship 7 Motel",
            "Birmingham Emmaus", "Holiday Inn Express Hotel & Suites", "Alexander Hamilton House","MBI Benefits",
            "Greenwood Acres Campground", "Inn At Vint Hill Farms", "Newport City Motel", "Manhattan Youth Recreation And Resources Inc",
            "Bed & Breakfast Of Greensburg", "Eggery Inn", "Schooner Creek Resort", "Best Western-Orlando E","Stanley Hotel",
            "Pelican Lake Campground Llc", "Ebersole Environmental Edctn", "Keywest Harbor Inn", "Heart Seed Inn & Spa",
            "Lion Inn", "Courtyard-Boston Waltham", "Thousand Trails-naco", "Mike Schell Domains For Sale", "Radisson-Denver North",
            "Outdoor Resorts Melbourne Bch", "Camp Crystal Lake", "Angler Motel", "Holiday Inn Corpus Christi", "Pocalla Springs Resort",
            "Tomlinson Black Realtors", "Evergreen Inn", "Mark McNutt"
        };

        public static string[] Companies
        {
            get
            {
                return new string[]
                {
                    "AC Hotels", "Aldemar Hotels & Spa", "Aloft Hotels", "Alrosa Hotels",
                    "B&G Hotels - Resorts", "Barcelo", "Barut Hotels", "Best Western",
                    "Blau Hotels & Resorts", "Crystal Hotels", "Domina", "Four Points",
                    "Four Seasons Hotels and Resorts", "Gloria Hotels & Resorts", "Golden Tulip",
                    "Grecotel", "H10 Hotels", "Hilton Hotels", "Holiday Inn", "Hoteis Real",
                    "Hyatt", "Iberostar Hotels & Resorts",  "Iberotel Hotels & Resorts", "Ibis Hotel",
                    "IFA Hotels & Resorts", "InterContinental Hotels Group", "Jumeirah", "Kempinski",
                    "Le Meridien", "LOPESAN Hotels & Resorts", "Maritim", "Marriott", "Mitsis",
                    "NH Hotels", "Occidental Hotels & Resorts", "Orient-Express Hotels, Trains & Cruises",
                    "Papillon Hotels Resorts & SPA", "PortAventura", "Pyramisa Hotels & Cruises",
                    "Radisson Hotels & Resorts", "Ramada", "Reef Oasis Hotels & Resorts", "Ritz Carlton",
                    "Riu Hotels & Resorts", "Rixos", "Sani", "Shangri-La", "Sheraton", "Sofitel", "Sokos",
                    "SolMelia Hotels & Resorts", "St Regis", "Starwood Hotels & Resorts",
                    "Steigenberger Hotels and Resorts", "The Luxury Collection", "Vincci Hoteles", "W Hotels",
                    "Westin Hotels & Resorts"
                };
            }
        }

        public static string[] Cities
        {
            get
            {
                return new string[]
                {
                    "KABUL", "TIRANA", "ALGIERS", "LUANDA", "BUENOS AIRES", "YEREVAN", "CANBERRA", "VIENNA",
                    "BAKU", "NASSAU", "MANAMA", "DHAKA", "BRIDGETOWN", "MINSK", "BRUSSELS", "BELMOPAN",
                    "PORTO-NOVO", "THIMPHU", "SUCRE", "SARAJEVO", "GABORONE", "BRASILIA", "SOFIA", "OUAGADOUGOU",
                    "BUJUMBURA", "PRAIA", "PHNOM PENH", "YAOUNDE", "OTTAWA", "BANGUI", "SANTIAGO", "BEIJING",
                    "BOGOTA", "MORONI", "SAN JOSE", "ZAGREB", "HAVANA", "NICOSIA", "PRAGUE", "COPENHAGEN",
                    "ROSEAU", "SANTO DOMINGO", "QUITO", "CAIRO", "SALVADOR", "MALABO", "ASMARA", "TALLINN",
                    "MBABANE", "ABABA", "SUVA", "HELSINKI", "PARIS", "LIBREVILLE", "THE BANJUL", "TBILISI",
                    "BERLIN", "ACCRA", "ATHENS", "GUATEMALA CITY", "CONAKRY", "BISSAU", "GEORGETOWN", "TEGUCIGALPA",
                    "BUDAPEST", "REYKJAVIK", "NEW DELHI", "JAKARTA", "TEHRAN", "BAGHDAD", "DUBLIN", "JERUSALEM",
                    "ROME", "KINGSTON", "TOKYO", "AMMAN", "ASTANA", "NAIROBI", "SOUTH TARAWA", "PRISTINA", "KUWAIT CITY",
                    "BISHKEK", "VIENTIANE", "RIGA", "BEIRUT", "MASERU", "MONROVIA", "TRIPOLI", "VADUZ", "VILNIUS",
                    "LUXEMBOURG", "ANTANANARIVO", "LILONGWE", "KUALA LUMPUR", "MALE", "BAMAKO", "VALLETTA", "NOUAKCHOTT",
                    "PORT LOUIS", "MEXICO CITY", "CHISINAU", "MONACO", "ULAANBAATAR", "PODGORICA", "RABAT", "MAPUTO",
                    "WINDHOEK", "KATHMANDU", "AMSTERDAM", "WELLINGTON", "MANAGUA", "NIAMEY", "ABUJA", "PYONGYANG",
                    "SKOPJE", "OSLO", "MUSCAT", "ISLAMABAD", "NGERULMUD", "EAST JERUSALEM", "PANAMA CITY", "ASUNCION",
                    "LIMA", "MANILA", "WARSAW", "LISBON", "DOHA", "BUCHAREST", "MOSCOW", "KIGALI", "CASTRIES", "APIA", "SAN MARINO",
                    "RIYADH", "DAKAR", "BELGRADE", "VICTORIA", "FREETOWN", "SINGAPORE", "BRATISLAVA", "LJUBLJANA",
                    "MOGADISHU", "SEOUL", "JUBA", "MADRID", "KHARTOUM", "PARAMARIBO", "STOCKHOLM", "BERN", "DAMASCUS",
                    "DUSHANBE", "DODOMA", "BANGKOK", "DILI", "LOME", "NUKUALOFA", "TUNIS", "ANKARA", "ASHGABAT",
                    "FUNAFUTI", "KAMPALA", "KIEV", "ABU DHABI", "LONDON", "WASHINGTON, D.C.", "MONTEVIDEO", "TASHKENT",
                    "PORT VILA", "VATICAN CITY", "CARACAS", "HANOI", "SANA", "LUSAKA", "HARARE"
                };
            }
        }

        public static string GetRandomFirstName()
        {
            return firstNames[random.Next(0, firstNames.Length)];
        }

        public static string GetRandomLastName()
        {
            return lastNames[random.Next(0, lastNames.Length)];
        }

        public static string GetRandomHotel()
        {
            return hotels[random.Next(0, hotels.Length)];
        }

        public static string GetRandomCity()
        {
            return Cities[random.Next(0, Cities.Length)];
        }
    }
}
