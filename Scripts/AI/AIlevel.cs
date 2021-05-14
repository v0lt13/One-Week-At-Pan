using UnityEngine;
using OneWeekAtPan.Core;

namespace OneWeekAtPan.AI
{
	public static class AIlevel
	{
		public static void PanMovingTime()
		{
			switch (PanAI.PAN_AI_LEVEL)
			{
				case 0:
					PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
					PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
					break;

				case 1:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 15;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 17;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 13;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 15;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 13;
							break;
					}
					break;

				case 2:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 14;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 16;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 12;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 12;
							break;
					}
					break;

				case 3:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 13;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 15;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 11;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 13;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;
					}
					break;

				case 4:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 12;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 12;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;
					}
					break;

				case 5:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 13;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 11;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 13;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;
					}
					break;

				case 6:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 12;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 13;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 12;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;
					}
					break;

				case 7:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 11;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 12;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;
					}
					break;

				case 8:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;
					}
					break;

				case 9:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 5;
							break;
					}
					break;

				case 10:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 12;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 4;
							break;
					}
					break;

				case 11:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;
					}
					break;

				case 12:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;
					}
					break;

				case 13:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;
					}
					break;

				case 14:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 5;
							break;
					}
					break;

				case 15:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 5;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 2;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 5;
							break;
					}
					break;

				case 16:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 5;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 2;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 5;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 2;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 4;
							break;
					}
					break;

				case 17:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 2;
							break;
					}
					break;

				case 18:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 5;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 2;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 5;
							break;
					}
					break;

				case 19:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 5;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 2;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 4;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 3;
							break;
					}
					break;

				case 20:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 1:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 2:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;

						case 3:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 5;
							break;

						case 4:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 2;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 4;
							break;

						case 5:
							PanAI.MIN_TIME_BETWEN_MOVEMENT = 1;
							PanAI.MAX_TIME_BETWEN_MOVEMENT = 3;
							break;
					}
					break;

				default:
					Debug.LogWarning("SomethingWentWrong");
					break;
			}
		}

		public static void MikeyMovingTime()
		{
			switch (MikeyAI.MIKEY_AI_LEVEL)
			{
				case 0:
					MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
					MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
					break;

				case 1:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 13;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 15;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 15;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 20;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 15;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 13;
							break;
					}
					break;

				case 2:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 12;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 15;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 15;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 19;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 12;
							break;
					}
					break;

				case 3:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 12;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 15;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 18;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 13;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;
					}
					break;

				case 4:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 11;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 15;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 17;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 12;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;
					}
					break;

				case 5:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 11;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 13;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 14;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 17;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 12;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;
					}
					break;

				case 6:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 13;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 14;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 16;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;
					}
					break;

				case 7:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 12;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 13;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 16;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;
					}
					break;

				case 8:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 12;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 13;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 15;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;
					}
					break;

				case 9:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 12;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;
					}
					break;

				case 10:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 15;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 17;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 12;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;
					}
					break;

				case 11:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 14;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 17;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 11;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;
					}
					break;

				case 12:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 14;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 16;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 11;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 13;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;
					}
					break;

				case 13:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 13;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 16;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 13;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;
					}
					break;

				case 14:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 13;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 15;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 12;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;
					}
					break;

				case 15:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 15;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 17;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 12;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 15;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 12;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 5;
							break;
					}
					break;

				case 16:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 14;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 17;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 12;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 2;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 5;
							break;
					}
					break;

				case 17:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 14;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 16;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 11;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 2;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 4;
							break;
					}
					break;

				case 18:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 13;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 16;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 11;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 13;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 4;
							break;
					}
					break;

				case 19:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 13;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 15;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 13;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 5;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 3;
							break;
					}
					break;

				case 20:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 11;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 1:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 2:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;

						case 3:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;

						case 4:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 2;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 4;
							break;

						case 5:
							MikeyAI.MIN_TIME_BETWEN_MOVEMENT = 1;
							MikeyAI.MAX_TIME_BETWEN_MOVEMENT = 2;
							break;
					}
					break;

				default:
					Debug.LogWarning("SomethingWentWrong");
					break;
			}
		}

		public static void TravisMovingTime()
		{
			switch (TravisAI.TRAVIS_AI_LEVEL)
			{
				case 0:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
					break;

				case 1:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 10;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 13;
					break;

				case 2:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 10;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 12;
					break;

				case 3:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 9;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 12;
					break;

				case 4:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 9;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 11;
					break;

				case 5:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 8;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 11;
					break;

				case 6:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 8;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 10;
					break;

				case 7:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 7;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 10;
					break;

				case 8:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 7;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 9;
					break;

				case 9:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 6;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 9;
					break;

				case 10:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 6;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 8;
					break;

				case 11:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 5;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 8;
					break;

				case 12:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 5;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 7;
					break;

				case 13:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 4;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 7;
					break;

				case 14:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 4;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 6;
					break;

				case 15:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 3;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 6;
					break;

				case 16:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 3;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 5;
					break;

				case 17:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 2;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 5;
					break;

				case 18:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 2;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 4;
					break;

				case 19:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 1;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 4;
					break;

				case 20:
					TravisAI.MIN_TIME_BETWEN_MOVEMENT = 1;
					TravisAI.MAX_TIME_BETWEN_MOVEMENT = 3;
					break;

				default:
					Debug.LogWarning("SomethingWentWrong");
					break;
			}
		}

		public static void OwlMovingTime()
		{
			switch (OwlAI.OWL_AI_LEVEL)
			{
				case 0:
					OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
					OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
					break;

				case 1:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 15;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 20;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 15;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 13;
							break;
					}
					break;

				case 2:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 15;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 19;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 12;
							break;
					}
					break;

				case 3:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 15;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 18;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 13;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;
					}
					break;

				case 4:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 15;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 17;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 12;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;
					}
					break;

				case 5:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 15;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 19;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 14;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 17;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 12;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;
					}
					break;

				case 6:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 15;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 18;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 14;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 16;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;
					}
					break;

				case 7:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 15;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 17;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 13;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 16;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;
					}
					break;

				case 8:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 14;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 17;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 13;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 15;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;
					}
					break;

				case 9:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 14;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 16;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 12;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;
					}
					break;

				case 10:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 15;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 17;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 13;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 16;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;
					}
					break;

				case 11:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 14;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 17;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 13;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 15;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;
					}
					break;

				case 12:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 14;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 16;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 12;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 15;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;
					}
					break;

				case 13:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 13;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 16;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 12;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;
					}
					break;

				case 14:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 13;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 15;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 11;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 7;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;
					}
					break;

				case 15:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 15;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 17;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 12;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 15;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 11;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 13;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 9;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 5;
							break;
					}
					break;

				case 16:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 14;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 17;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 12;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 13;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 6;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 2;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 5;
							break;
					}
					break;

				case 17:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 14;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 16;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 11;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 12;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 8;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 2;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 4;
							break;
					}
					break;

				case 18:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 13;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 16;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 11;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 13;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 12;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 5;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 4;
							break;
					}
					break;

				case 19:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 13;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 15;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 10;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 13;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 7;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 3;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 5;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 3;
							break;
					}
					break;

				case 20:
					switch (Main.NIGHT_HOUR)
					{
						case 12:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 11;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 14;
							break;

						case 1:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 9;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 11;
							break;

						case 2:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 8;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 10;
							break;

						case 3:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 4;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 6;
							break;

						case 4:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 2;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 4;
							break;

						case 5:
							OwlAI.MIN_TIME_BETWEN_MOVEMENT = 1;
							OwlAI.MAX_TIME_BETWEN_MOVEMENT = 2;
							break;
					}
					break;

				default:
					Debug.LogWarning("SomethingWentWrong");
					break;
			}
		}

		public static void EyeDemonMovingTime()
		{
			switch (Main.NIGHT_HOUR)
			{
				case 12:
					EyeDemonAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
					EyeDemonAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
					break;

				case 1:
					EyeDemonAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
					EyeDemonAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
					break;

				case 2:
					EyeDemonAI.MIN_TIME_BETWEN_MOVEMENT = 1000000;
					EyeDemonAI.MAX_TIME_BETWEN_MOVEMENT = 1000000;
					break;

				case 3:
					EyeDemonAI.MIN_TIME_BETWEN_MOVEMENT = 3;
					EyeDemonAI.MAX_TIME_BETWEN_MOVEMENT = 5;
					break;

				case 4:
					EyeDemonAI.MIN_TIME_BETWEN_MOVEMENT = 2;
					EyeDemonAI.MAX_TIME_BETWEN_MOVEMENT = 4;
					break;

				case 5:
					EyeDemonAI.MIN_TIME_BETWEN_MOVEMENT = 1;
					EyeDemonAI.MAX_TIME_BETWEN_MOVEMENT = 3;
					break;
			}
		}
	}
}