using NUnit.Framework;

namespace AdventOfCode2016.Day4
{
    [TestFixture]
    public class When_checking_if_a_room_is_a_real_room
    {
        [Test]
        public void Then_the_sector_id_of_the_room_is_returned_for_test_case_1()
        {
            var encryptedName = "aaaaa-bbb-z-y-x-123[abxyz]";
            var room = new Room(encryptedName);
            var result = room.IsReal();
            Assert.That(result, Is.EqualTo(123));
        }

        [Test]
        public void Then_the_sector_id_of_the_room_is_returned_for_test_case_2()
        {
            var encryptedName = "a-b-c-d-e-f-g-h-987[abcde]";
            var room = new Room(encryptedName);
            var result = room.IsReal();
            Assert.That(result, Is.EqualTo(987));
        }

        [Test]
        public void Then_the_sector_id_of_the_room_is_returned_for_test_case_3()
        {
            var encryptedName = "not-a-real-room-404[oarel]";
            var room = new Room(encryptedName);
            var result = room.IsReal();
            Assert.That(result, Is.EqualTo(404));
        }

        [Test]
        public void Then_minus_1_is_returned_for_test_case_4_because_it_is_not_a_real_room()
        {
            var encryptedName = "totally-real-room-200[decoy]";
            var room = new Room(encryptedName);
            var result = room.IsReal();
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Then_sector_ids_need_to_be_counted_to_solve_part_1()
        {
            var input = Input.Text;

            var rooms = input.Split('\n');
            var result = 0;

            foreach (var encryptedRoomName in rooms)
            {
                var room = new Room(encryptedRoomName.Trim());
                var roomSectorId = room.IsReal();

                if (roomSectorId > -1)
                {
                    result += roomSectorId;
                }
            }
        }
    }
}
