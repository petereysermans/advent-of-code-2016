using System;
using NUnit.Framework;

namespace AdventOfCode2016.Day4
{
    [TestFixture]
    public class When_searching_for_the_sector_id_of_the_north_pole_room_where_the_objects_are_stored
    {
        [Test]
        public void Then_the_sector_id_is_found_by_decrypthing_the_room_names()
        {
            var encryptedRoomNames = Input.Text.Split('\n');
            var nameDecryptor = new NameDecryptor();

            foreach (var name in encryptedRoomNames)
            {
                var decryptedName = nameDecryptor.Decrypt(name.Trim());
                Console.WriteLine("name: " + decryptedName + " encrypted name: " + name.Trim());
            }
        }
    }
}
