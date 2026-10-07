namespace G_NET106_Advanced_Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise01
            //Create a program that manages student grades using One Of Collections

            //Console.WriteLine("exercise 1 : ");
            //Console.WriteLine();

            //List<int> grades = new List<int>
            //{
            //    85,92,78,95,88,70,100,65
            //};

            //Console.WriteLine("collection ");
            //for (int i = 0; i < grades.Count; i++)
            //{
            //    Console.WriteLine(grades[i] + ",");
            //}
            //Console.WriteLine("count : " + grades.Count);
            //Console.WriteLine("first grade : " + grades[0]);
            //Console.WriteLine("last grade : " + grades[grades.Count - 1]);

            //Console.WriteLine("after sorting : ");
            //grades.Sort();
            //for (int i = 0; i < grades.Count; i++)
            //{
            //    Console.WriteLine(grades[i] + ",");
            //}

            //int above = grades.Find(x => x > 90);
            //Console.WriteLine("first grade above 90 : " + above);

            //List<int> below = grades.FindAll(x => x < 75);
            //Console.WriteLine("grades below 75 : ");

            //foreach (int grade in below)
            //{
            //    Console.Write(grade + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("contain 100 : " + grades.Contains(100));

            //List<string> gradeMessages = new List<string>();

            //foreach (int grade in grades)
            //{
            //    gradeMessages.Add("Grade: " + grade);
            //}

            //Console.WriteLine("Grade messages:");

            //foreach (string message in gradeMessages)
            //{
            //    Console.WriteLine(message);
            //}
            #endregion

            #region Exercise02
            //Create a leaderboard that automatically sorts players by score.

            //Console.WriteLine("exercise 2 : ");
            //Console.WriteLine();

            //SortedDictionary<int,string> leader=new SortedDictionary<int,string>();
            //leader.Add(500, "ahmed");
            //leader.Add(200, "sara");
            //leader.Add(800, "ali");
            //leader.Add(350, "mona");

            //Console.WriteLine("leaderboard : ");

            //foreach(KeyValuePair<int,string> pair in leader)
            //{
            //    Console.WriteLine(pair.Key+" , "+pair.Value);
            //}

            //foreach (int key in leader.Keys)
            //{
            //    Console.WriteLine("First key: " + key);
            //    break;
            //}

            //foreach (string value in leader.Values)
            //{
            //    Console.WriteLine("First value: " + value);
            //    break;
            //}

            //Console.WriteLine("does score 500 exists ? : "+leader.ContainsKey(500));

            //if (leader.TryGetValue(999, out string player))
            //{
            //    Console.WriteLine("the player with score 999 : " + player);
            //}
            //else
            //{
            //    Console.WriteLine("player with score 999 does not exist");
            //}

            //leader.Remove(200);
            //Console.WriteLine("leaderboard after remove 200 : ");

            //foreach (KeyValuePair<int, string> pair in leader)
            //{
            //    Console.WriteLine(pair.Key + " = " + pair.Value);
            //}
            #endregion

            #region Exercise03
            //Build a phone book application.

            //Console.WriteLine("exercise 3 : ");
            //Console.WriteLine();

            //Dictionary<string,string> phonebook=new Dictionary<string,string>();
            //phonebook.Add("ahmed", "01034791794");
            //phonebook.Add("sara", "01130917381");
            //phonebook.Add("ali", "01210483921");
            //phonebook.Add("mona", "01510384920");

            //phonebook["essam"] = "01032435141";

            //try
            //{
            //    phonebook.Add("ahmed", "01034791794");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("erorr : "+ex.Message);
            //}

            //bool newAdd = phonebook.TryAdd("ahmed", "01099988877");
            //Console.WriteLine("newAdd succeeded : " + newAdd);

            //Console.WriteLine("does sleem exist : " +phonebook.ContainsKey("sleem"));

            //if (phonebook.TryGetValue("sleem",out string phone))
            //{
            //    Console.WriteLine("phone : " + phone);
            //}
            //else
            //{
            //    Console.WriteLine("phone not found");
            //}

            //Console.WriteLine("key : ");
            //foreach (string key in phonebook.Keys)
            //{
            //    Console.Write(key + " ");
            //}

            //Console.WriteLine();

            //Console.WriteLine("value : ");
            //foreach (string value in phonebook.Values)
            //{
            //    Console.Write(value + " ");
            //}
            #endregion

            #region Exercise04
            //Use Collection to manage unique email addresses.

            //Console.WriteLine("exercise 4 : ");
            //Console.WriteLine();

            //HashSet<string> emails = new HashSet<string>();

            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com");
            //emails.Add("sara@test.com");
            //emails.Add("Sara@test.com");

            //Console.WriteLine("count : "+emails.Count);

            /*the atually count here is 2 bc
            the hash set does not allow duplicate 
            and it ignore upper and lower cases diffrences
            */

            //HashSet<int> setA = new HashSet<int>
            //{
            //    1, 2, 3, 4, 5
            //};

            //HashSet<int> setB = new HashSet<int>
            //{
            //    4, 5, 6, 7, 8
            //};

            //HashSet<int> unionSet = new HashSet<int>
            //{
            //    1, 2, 3, 4, 5
            //};

            //unionSet.UnionWith(setB);

            //Console.WriteLine("union : ");
            //foreach (int union in unionSet)
            //{
            //    Console.Write(union + ",");
            //}

            //HashSet<int> intersectSet = new HashSet<int>
            //{
            //    1, 2, 3, 4, 5
            //};

            //intersectSet.IntersectWith(setB);
            //Console.WriteLine();
            //Console.WriteLine("intersection : ");
            //foreach (int intersection in intersectSet)
            //{
            //    Console.Write(intersection + ",");
            //}

            //HashSet<int> exceptSet = new HashSet<int>
            //{
            //    1, 2, 3, 4, 5
            //};

            //exceptSet.ExceptWith(setB);
            //Console.WriteLine();
            //Console.WriteLine("except : ");
            //foreach (int except in exceptSet)
            //{
            //    Console.Write(except + ",");
            //}

            //HashSet<int> subset = new HashSet<int>
            //{
            //    1, 2
            //};
            //Console.WriteLine();
            //Console.WriteLine("is 1,2 subset of Set A : " +subset.IsSubsetOf(setA));
            #endregion
        }
    }
}
