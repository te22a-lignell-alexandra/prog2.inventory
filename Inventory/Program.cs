Character guy = new(){
    Name = "Sven" ,
    Hp = 50
};

Weapon chair = new(){
    MinDamage = 30 ,
    MaxDamage = 60
};

Consumable soup = new(){

};

guy.Backpack.items.Add(chair);
guy.Backpack.items.Add();