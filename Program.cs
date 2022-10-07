using spu111_weapons;

Player player1 = new Player()
{
    Name = "Nikita",
    Health = 100,
    Weapon = new Pistol()
};
Player player2 = new Player()
{
    Name = "Stroyak",
    Health = 85,
    Weapon = new Pistol()
};

player1.AttackPlayer(player2);
player2.AttackPlayer(player1);

Console.WriteLine("Первый игрок резко выхватывает у второго оружие");
player1.Weapon = new Pistol();
player2.Weapon = null;

player1.AttackPlayer(player2);

Console.WriteLine("Второй игрок достаёт Ракетомёт");
player2.Weapon = new Rocket_Launcher();
player2.AttackPlayer(player1);
player1.AttackPlayer(player2);
player2.AttackPlayer(player1);
player1.AttackPlayer(player2);
player2.AttackPlayer(player1);
player1.AttackPlayer(player2);
player1.HealthCheck();
player2.HealthCheck();

Console.WriteLine("Второй игрок достаёт нож");
player2.Weapon = new Knife();
player2.AttackPlayer(player1);
