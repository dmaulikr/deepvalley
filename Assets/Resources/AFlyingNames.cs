﻿using UnityEngine;
using System.Collections;

public class AFlyingNames {

	System.Random _randomGen;

	private string[] _flyingNames = new string[]{
		"BabyDuck.obj",
		"Baseballer.obj",
		"Basketballer.obj",
		"Basketballer_Bounce.obj",
		"Black_Sheep.obj",
		"Blue_Frog.obj",
		"Brown_Rabbit.obj",
		"Bull.obj",
		"Cai_Shen.obj",
		"Capybara.obj",
		"Cat.obj",
		"Chicken.obj",
		"Cow.obj",
		"Dark_Lord.obj",
		"Dog.obj",
		"Doge.obj",
		"Doges_Cousin.obj",
		"Duck.obj",
		"Electric.obj",
		"Epoch.obj",
		"Frank.obj",
		"Fuzz.obj",
		"Ganster.obj",
		"Ghost.obj",
		"Ghost_With_Chains.obj",
		"Gift_1.obj",
		"Gifty_Idle.obj",
		"Gifty_Jump_1.obj",
		"Gifty_Jump_2.obj",
		"Goat.obj",
		"Gravedigger.obj",
		"Gravedigger_Lantern.obj",
		"Gray_Rabbit.obj",
		"GreenFrog.obj",
		"Hipster_Whale.obj",
		"Horse.obj",
		"Kiwi.obj",
		"Old_Man.obj",
		"Omnious_Cat.obj",
		"Penguin.obj",
		"Pew_Pew_Pug.obj",
		"Pig.obj",
		"Pigeon.obj",
		"Piggy_Bank.obj",
		"Pink_Rabbit.obj",
		"Purple_Frog.obj",
		"Red_Frog.obj",
		"Robot.obj",
		"Sedan.obj",
		"Sheep.obj",
		"Snail.obj",
		"Tabby_Cat.obj",
		"Taxi.obj",
		"Tortoise.obj",
		"Truck.obj",
		"Unihorse.obj",
		"Vampire.obj",
		"Wagon.obj",
		"Wizard.obj",
		"Wolf.obj",
		"Zombie.obj",
		"Zombie_Headless.obj",
		"bat_3.obj",
		"bird_flap_03.obj",
		"bird_idle_01.obj",
		"eagle_2.obj",
		"grave_01.obj",
		"grave_02.obj",
		"grave_03.obj",
		"lantern_cny.obj",
		"lilypad.obj",
		"missile_truck.obj",
		"muscle.obj",
		"oil_truck.obj",
		"pergola_cny_1.obj",
		"pergola_cny_2.obj",
		"snowman.obj",
		"train_back.obj",
		"train_front.obj",
		"train_middle.obj",
		"truck_blue.obj",
		"truck_green.obj",
		"ute.obj",
		"xi.obj"
	};

	public string getRandomFlyingName() {
		if (_randomGen == null) {
			_randomGen = new System.Random (Time.time.ToString ().GetHashCode ());
		}
		string name = _flyingNames [_randomGen.Next (0, _flyingNames.GetLength (0) - 1)];
		return name.Substring(0,name.Length-4);
	}
}