using Newtonsoft.Json;

namespace _11_Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deserialize 反序列化：
            Skill[] skillArray =  JsonConvert.DeserializeObject<Skill[]>(File.ReadAllText("Skilljson.json"));
            //或者使用List存储
            //List<Skill> skillList = JsonConvert.DeserializeObject<List<Skill>>(File.ReadAllText("Skilljson.json"));
            foreach (Skill skill in skillArray)
            {
                Console.WriteLine($"{skill.Id},{skill.Name},{skill.Damage}");
            }

            //Serialize 序列化
            Skill MySkill = new Skill();
            MySkill.Id = 6;
            MySkill.Name = "song";
            MySkill.Damage = 300;
            string str = JsonConvert.SerializeObject(MySkill);
            Console.WriteLine(str);
        }
    }
}