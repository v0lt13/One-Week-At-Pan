using UnityEngine;

public static class AIlevel
{
    public static void PanMovingTime()
    {
        switch (PanAI.panAIlevel)
        {
            case 0:
                PanAI.minTimeBetwenMovement = 1000000;
                PanAI.maxTimeBetwenMovement = 1000000;
                break;

            case 1:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 15;
                        PanAI.maxTimeBetwenMovement = 17;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 13;
                        PanAI.maxTimeBetwenMovement = 15;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 10;
                        PanAI.maxTimeBetwenMovement = 13;
                        break;
                }
                break;

            case 2:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 14;
                        PanAI.maxTimeBetwenMovement = 16;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 12;
                        PanAI.maxTimeBetwenMovement = 14;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 9;
                        PanAI.maxTimeBetwenMovement = 12;
                        break;
                }
                break;

            case 3:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 13;
                        PanAI.maxTimeBetwenMovement = 15;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 11;
                        PanAI.maxTimeBetwenMovement = 13;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 8;
                        PanAI.maxTimeBetwenMovement = 11;
                        break;
                }
                break;

            case 4:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 12;
                        PanAI.maxTimeBetwenMovement = 14;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 10;
                        PanAI.maxTimeBetwenMovement = 12;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 7;
                        PanAI.maxTimeBetwenMovement = 10;
                        break;
                }
                break;

            case 5:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 13;
                        PanAI.maxTimeBetwenMovement = 14;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 11;
                        PanAI.maxTimeBetwenMovement = 13;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 9;
                        PanAI.maxTimeBetwenMovement = 11;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 6;
                        PanAI.maxTimeBetwenMovement = 9;
                        break;
                }
                break;

            case 6:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 12;
                        PanAI.maxTimeBetwenMovement = 13;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 10;
                        PanAI.maxTimeBetwenMovement = 12;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 8;
                        PanAI.maxTimeBetwenMovement = 10;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 5;
                        PanAI.maxTimeBetwenMovement = 8;
                        break;
                }
                break;

            case 7:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 11;
                        PanAI.maxTimeBetwenMovement = 12;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 9;
                        PanAI.maxTimeBetwenMovement = 11;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 7;
                        PanAI.maxTimeBetwenMovement = 9;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 4;
                        PanAI.maxTimeBetwenMovement = 7;
                        break;
                }
                break;

            case 8:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 10;
                        PanAI.maxTimeBetwenMovement = 11;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 8;
                        PanAI.maxTimeBetwenMovement = 10;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 6;
                        PanAI.maxTimeBetwenMovement = 8;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 3;
                        PanAI.maxTimeBetwenMovement = 6;
                        break;
                }
                break;

            case 9:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 9;
                        PanAI.maxTimeBetwenMovement = 10;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 7;
                        PanAI.maxTimeBetwenMovement = 9;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 5;
                        PanAI.maxTimeBetwenMovement = 7;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 3;
                        PanAI.maxTimeBetwenMovement = 5;
                        break;
                }
                break;

            case 10:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 10;
                        PanAI.maxTimeBetwenMovement = 12;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 8;
                        PanAI.maxTimeBetwenMovement = 9;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 6;
                        PanAI.maxTimeBetwenMovement = 8;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 4;
                        PanAI.maxTimeBetwenMovement = 6;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 3;
                        PanAI.maxTimeBetwenMovement = 4;
                        break;
                }
                break;

            case 11:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 9;
                        PanAI.maxTimeBetwenMovement = 11;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 7;
                        PanAI.maxTimeBetwenMovement = 8;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 6;
                        PanAI.maxTimeBetwenMovement = 7;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 3;
                        PanAI.maxTimeBetwenMovement = 5;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 2;
                        PanAI.maxTimeBetwenMovement = 3;
                        break;
                }
                break;

            case 12:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 9;
                        PanAI.maxTimeBetwenMovement = 10;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 6;
                        PanAI.maxTimeBetwenMovement = 8;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 5;
                        PanAI.maxTimeBetwenMovement = 7;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 2;
                        PanAI.maxTimeBetwenMovement = 4;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 1;
                        PanAI.maxTimeBetwenMovement = 3;
                        break;
                }
                break;

            case 13:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 8;
                        PanAI.maxTimeBetwenMovement = 10;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 5;
                        PanAI.maxTimeBetwenMovement = 8;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 4;
                        PanAI.maxTimeBetwenMovement = 7;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 2;
                        PanAI.maxTimeBetwenMovement = 3;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 1;
                        PanAI.maxTimeBetwenMovement = 3;
                        break;
                }
                break;

            case 14:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 1000000;
                        PanAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 7;
                        PanAI.maxTimeBetwenMovement = 10;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 5;
                        PanAI.maxTimeBetwenMovement = 7;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 4;
                        PanAI.maxTimeBetwenMovement = 6;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 2;
                        PanAI.maxTimeBetwenMovement = 3;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 1;
                        PanAI.maxTimeBetwenMovement = 3;
                        break;
                }
                break;

            case 15:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 9;
                        PanAI.maxTimeBetwenMovement = 11;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 7;
                        PanAI.maxTimeBetwenMovement = 9;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 4;
                        PanAI.maxTimeBetwenMovement = 7;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 3;
                        PanAI.maxTimeBetwenMovement = 6;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 1;
                        PanAI.maxTimeBetwenMovement = 3;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 1;
                        PanAI.maxTimeBetwenMovement = 2;
                        break;
                }
                break;

            case 16:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 8;
                        PanAI.maxTimeBetwenMovement = 11;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 6;
                        PanAI.maxTimeBetwenMovement = 9;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 4;
                        PanAI.maxTimeBetwenMovement = 6;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 3;
                        PanAI.maxTimeBetwenMovement = 5;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 1;
                        PanAI.maxTimeBetwenMovement = 3;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 1;
                        PanAI.maxTimeBetwenMovement = 2;
                        break;
                }
                break;

            case 17:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 7;
                        PanAI.maxTimeBetwenMovement = 10;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 6;
                        PanAI.maxTimeBetwenMovement = 8;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 3;
                        PanAI.maxTimeBetwenMovement = 6;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 3;
                        PanAI.maxTimeBetwenMovement = 4;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 1;
                        PanAI.maxTimeBetwenMovement = 2;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 0;
                        PanAI.maxTimeBetwenMovement = 2;
                        break;
                }
                break;

            case 18:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 7;
                        PanAI.maxTimeBetwenMovement = 9;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 5;
                        PanAI.maxTimeBetwenMovement = 7;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 3;
                        PanAI.maxTimeBetwenMovement = 5;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 2;
                        PanAI.maxTimeBetwenMovement = 4;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 1;
                        PanAI.maxTimeBetwenMovement = 2;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 0;
                        PanAI.maxTimeBetwenMovement = 2;
                        break;
                }
                break;

            case 19:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 6;
                        PanAI.maxTimeBetwenMovement = 8;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 4;
                        PanAI.maxTimeBetwenMovement = 6;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 2;
                        PanAI.maxTimeBetwenMovement = 4;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 1;
                        PanAI.maxTimeBetwenMovement = 4;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 0;
                        PanAI.maxTimeBetwenMovement = 2;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 0;
                        PanAI.maxTimeBetwenMovement = 1;
                        break;
                }
                break;

            case 20:
                switch (Main.nightHour)
                {
                    case 12:
                        PanAI.minTimeBetwenMovement = 5;
                        PanAI.maxTimeBetwenMovement = 7;
                        break;

                    case 1:
                        PanAI.minTimeBetwenMovement = 3;
                        PanAI.maxTimeBetwenMovement = 5;
                        break;

                    case 2:
                        PanAI.minTimeBetwenMovement = 1;
                        PanAI.maxTimeBetwenMovement = 3;
                        break;

                    case 3:
                        PanAI.minTimeBetwenMovement = 0;
                        PanAI.maxTimeBetwenMovement = 3;
                        break;

                    case 4:
                        PanAI.minTimeBetwenMovement = 0;
                        PanAI.maxTimeBetwenMovement = 2;
                        break;

                    case 5:
                        PanAI.minTimeBetwenMovement = 0;
                        PanAI.maxTimeBetwenMovement = 1;
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
        switch (MikeyAI.mikeyAIlevel)
        {
            case 0:
                MikeyAI.minTimeBetwenMovement = 1000000;
                MikeyAI.maxTimeBetwenMovement = 1000000;
                break;

            case 1:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 13;
                        MikeyAI.maxTimeBetwenMovement = 15;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 15;
                        MikeyAI.maxTimeBetwenMovement = 20;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 10;
                        MikeyAI.maxTimeBetwenMovement = 15;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 8;
                        MikeyAI.maxTimeBetwenMovement = 13;
                        break;
                }
                break;

            case 2:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 12;
                        MikeyAI.maxTimeBetwenMovement = 15;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 15;
                        MikeyAI.maxTimeBetwenMovement = 19;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 10;
                        MikeyAI.maxTimeBetwenMovement = 14;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 8;
                        MikeyAI.maxTimeBetwenMovement = 12;
                        break;
                }
                break;

            case 3:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 12;
                        MikeyAI.maxTimeBetwenMovement = 14;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 15;
                        MikeyAI.maxTimeBetwenMovement = 18;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 10;
                        MikeyAI.maxTimeBetwenMovement = 13;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 8;
                        MikeyAI.maxTimeBetwenMovement = 11;
                        break;
                }
                break;

            case 4:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 11;
                        MikeyAI.maxTimeBetwenMovement = 14;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 15;
                        MikeyAI.maxTimeBetwenMovement = 17;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 10;
                        MikeyAI.maxTimeBetwenMovement = 12;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 8;
                        MikeyAI.maxTimeBetwenMovement = 10;
                        break;
                }
                break;

            case 5:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 11;
                        MikeyAI.maxTimeBetwenMovement = 13;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 14;
                        MikeyAI.maxTimeBetwenMovement = 17;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 9;
                        MikeyAI.maxTimeBetwenMovement = 12;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 7;
                        MikeyAI.maxTimeBetwenMovement = 10;
                        break;
                }
                break;

            case 6:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 10;
                        MikeyAI.maxTimeBetwenMovement = 13;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 14;
                        MikeyAI.maxTimeBetwenMovement = 16;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 9;
                        MikeyAI.maxTimeBetwenMovement = 11;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 7;
                        MikeyAI.maxTimeBetwenMovement = 9;
                        break;
                }
                break;

            case 7:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 10;
                        MikeyAI.maxTimeBetwenMovement = 12;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 13;
                        MikeyAI.maxTimeBetwenMovement = 16;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 8;
                        MikeyAI.maxTimeBetwenMovement = 11;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 6;
                        MikeyAI.maxTimeBetwenMovement = 9;
                        break;
                }
                break;

            case 8:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 9;
                        MikeyAI.maxTimeBetwenMovement = 12;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 13;
                        MikeyAI.maxTimeBetwenMovement = 15;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 8;
                        MikeyAI.maxTimeBetwenMovement = 10;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 6;
                        MikeyAI.maxTimeBetwenMovement = 8;
                        break;
                }
                break;

            case 9:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 9;
                        MikeyAI.maxTimeBetwenMovement = 11;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 12;
                        MikeyAI.maxTimeBetwenMovement = 14;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 7;
                        MikeyAI.maxTimeBetwenMovement = 10;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 5;
                        MikeyAI.maxTimeBetwenMovement = 8;
                        break;
                }
                break;

            case 10:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 15;
                        MikeyAI.maxTimeBetwenMovement = 17;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 12;
                        MikeyAI.maxTimeBetwenMovement = 14;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 9;
                        MikeyAI.maxTimeBetwenMovement = 11;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 7;
                        MikeyAI.maxTimeBetwenMovement = 10;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 5;
                        MikeyAI.maxTimeBetwenMovement = 8;
                        break;
                }
                break;

            case 11:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 14;
                        MikeyAI.maxTimeBetwenMovement = 17;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 11;
                        MikeyAI.maxTimeBetwenMovement = 14;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 8;
                        MikeyAI.maxTimeBetwenMovement = 11;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 7;
                        MikeyAI.maxTimeBetwenMovement = 9;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 5;
                        MikeyAI.maxTimeBetwenMovement = 7;
                        break;
                }
                break;

            case 12:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 14;
                        MikeyAI.maxTimeBetwenMovement = 16;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 11;
                        MikeyAI.maxTimeBetwenMovement = 13;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 8;
                        MikeyAI.maxTimeBetwenMovement = 10;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 6;
                        MikeyAI.maxTimeBetwenMovement = 9;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 4;
                        MikeyAI.maxTimeBetwenMovement = 7;
                        break;
                }
                break;

            case 13:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 13;
                        MikeyAI.maxTimeBetwenMovement = 16;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 10;
                        MikeyAI.maxTimeBetwenMovement = 13;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 7;
                        MikeyAI.maxTimeBetwenMovement = 10;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 6;
                        MikeyAI.maxTimeBetwenMovement = 8;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 4;
                        MikeyAI.maxTimeBetwenMovement = 6;
                        break;
                }
                break;

            case 14:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 1000000;
                        MikeyAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 13;
                        MikeyAI.maxTimeBetwenMovement = 15;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 10;
                        MikeyAI.maxTimeBetwenMovement = 12;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 7;
                        MikeyAI.maxTimeBetwenMovement = 9;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 5;
                        MikeyAI.maxTimeBetwenMovement = 8;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 3;
                        MikeyAI.maxTimeBetwenMovement = 6;
                        break;
                }
                break;

            case 15:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 15;
                        MikeyAI.maxTimeBetwenMovement = 17;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 12;
                        MikeyAI.maxTimeBetwenMovement = 15;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 9;
                        MikeyAI.maxTimeBetwenMovement = 12;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 6;
                        MikeyAI.maxTimeBetwenMovement = 9;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 5;
                        MikeyAI.maxTimeBetwenMovement = 7;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 3;
                        MikeyAI.maxTimeBetwenMovement = 5;
                        break;
                }
                break;

            case 16:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 14;
                        MikeyAI.maxTimeBetwenMovement = 17;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 12;
                        MikeyAI.maxTimeBetwenMovement = 14;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 9;
                        MikeyAI.maxTimeBetwenMovement = 11;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 6;
                        MikeyAI.maxTimeBetwenMovement = 8;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 4;
                        MikeyAI.maxTimeBetwenMovement = 7;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 2;
                        MikeyAI.maxTimeBetwenMovement = 5;
                        break;
                }
                break;

            case 17:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 14;
                        MikeyAI.maxTimeBetwenMovement = 16;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 11;
                        MikeyAI.maxTimeBetwenMovement = 14;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 8;
                        MikeyAI.maxTimeBetwenMovement = 11;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 5;
                        MikeyAI.maxTimeBetwenMovement = 8;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 4;
                        MikeyAI.maxTimeBetwenMovement = 6;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 2;
                        MikeyAI.maxTimeBetwenMovement = 4;
                        break;
                }
                break;

            case 18:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 13;
                        MikeyAI.maxTimeBetwenMovement = 16;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 11;
                        MikeyAI.maxTimeBetwenMovement = 13;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 8;
                        MikeyAI.maxTimeBetwenMovement = 10;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 5;
                        MikeyAI.maxTimeBetwenMovement = 7;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 3;
                        MikeyAI.maxTimeBetwenMovement = 6;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 1;
                        MikeyAI.maxTimeBetwenMovement = 4;
                        break;
                }
                break;

            case 19:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 13;
                        MikeyAI.maxTimeBetwenMovement = 15;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 10;
                        MikeyAI.maxTimeBetwenMovement = 13;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 7;
                        MikeyAI.maxTimeBetwenMovement = 10;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 4;
                        MikeyAI.maxTimeBetwenMovement = 7;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 3;
                        MikeyAI.maxTimeBetwenMovement = 5;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 1;
                        MikeyAI.maxTimeBetwenMovement = 3;
                        break;
                }
                break;

            case 20:
                switch (Main.nightHour)
                {
                    case 12:
                        MikeyAI.minTimeBetwenMovement = 11;
                        MikeyAI.maxTimeBetwenMovement = 14;
                        break;

                    case 1:
                        MikeyAI.minTimeBetwenMovement = 9;
                        MikeyAI.maxTimeBetwenMovement = 11;
                        break;

                    case 2:
                        MikeyAI.minTimeBetwenMovement = 6;
                        MikeyAI.maxTimeBetwenMovement = 9;
                        break;

                    case 3:
                        MikeyAI.minTimeBetwenMovement = 4;
                        MikeyAI.maxTimeBetwenMovement = 6;
                        break;

                    case 4:
                        MikeyAI.minTimeBetwenMovement = 2;
                        MikeyAI.maxTimeBetwenMovement = 4;
                        break;

                    case 5:
                        MikeyAI.minTimeBetwenMovement = 1;
                        MikeyAI.maxTimeBetwenMovement = 2;
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
		switch (TravisAI.travisAILevel)
		{
            case 0:
                TravisAI.minTimeBetwenMovement = 1000000;
                TravisAI.maxTimeBetwenMovement = 1000000;
                break;

            case 1:
                TravisAI.minTimeBetwenMovement = 10;
                TravisAI.maxTimeBetwenMovement = 13;
                break;

            case 2:
                TravisAI.minTimeBetwenMovement = 10;
                TravisAI.maxTimeBetwenMovement = 12;
                break;

            case 3:
                TravisAI.minTimeBetwenMovement = 9;
                TravisAI.maxTimeBetwenMovement = 12;
                break;

            case 4:
                TravisAI.minTimeBetwenMovement = 9;
                TravisAI.maxTimeBetwenMovement = 11;
                break;

            case 5:
                TravisAI.minTimeBetwenMovement = 8;
                TravisAI.maxTimeBetwenMovement = 11;
                break;

            case 6:
                TravisAI.minTimeBetwenMovement = 8;
                TravisAI.maxTimeBetwenMovement = 10;
                break;

            case 7:
                TravisAI.minTimeBetwenMovement = 7;
                TravisAI.maxTimeBetwenMovement = 10;
                break;

            case 8:
                TravisAI.minTimeBetwenMovement = 7;
                TravisAI.maxTimeBetwenMovement = 9;
                break;

            case 9:
                TravisAI.minTimeBetwenMovement = 6;
                TravisAI.maxTimeBetwenMovement = 9;
                break;

            case 10:
                TravisAI.minTimeBetwenMovement = 6;
                TravisAI.maxTimeBetwenMovement = 8;
                break;

            case 11:
                TravisAI.minTimeBetwenMovement = 5;
                TravisAI.maxTimeBetwenMovement = 8;
                break;

            case 12:
                TravisAI.minTimeBetwenMovement = 5;
                TravisAI.maxTimeBetwenMovement = 7;
                break;

            case 13:
                TravisAI.minTimeBetwenMovement = 4;
                TravisAI.maxTimeBetwenMovement = 7;
                break;

            case 14:
                TravisAI.minTimeBetwenMovement = 4;
                TravisAI.maxTimeBetwenMovement = 6;
                break;

            case 15:
                TravisAI.minTimeBetwenMovement = 3;
                TravisAI.maxTimeBetwenMovement = 6;
                break;

            case 16:
                TravisAI.minTimeBetwenMovement = 3;
                TravisAI.maxTimeBetwenMovement = 5;
                break;

            case 17:
                TravisAI.minTimeBetwenMovement = 2;
                TravisAI.maxTimeBetwenMovement = 5;
                break;

            case 18:
                TravisAI.minTimeBetwenMovement = 2;
                TravisAI.maxTimeBetwenMovement = 4;
                break;

            case 19:
                TravisAI.minTimeBetwenMovement = 1;
                TravisAI.maxTimeBetwenMovement = 4;
                break;

            case 20:
                TravisAI.minTimeBetwenMovement = 1;
                TravisAI.maxTimeBetwenMovement = 3;
                break;

            default:
                Debug.LogWarning("SomethingWentWrong");
                break;
        }
	}

    public static void OwlMovingTime()
	{
        switch (OwlAI.owlAILevel)
        {
            case 0:
                OwlAI.minTimeBetwenMovement = 1000000;
                OwlAI.maxTimeBetwenMovement = 1000000;
                break;

            case 1:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 15;
                        OwlAI.maxTimeBetwenMovement = 20;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 10;
                        OwlAI.maxTimeBetwenMovement = 15;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 8;
                        OwlAI.maxTimeBetwenMovement = 13;
                        break;
                }
                break;

            case 2:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 15;
                        OwlAI.maxTimeBetwenMovement = 19;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 10;
                        OwlAI.maxTimeBetwenMovement = 14;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 8;
                        OwlAI.maxTimeBetwenMovement = 12;
                        break;
                }
                break;

            case 3:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 15;
                        OwlAI.maxTimeBetwenMovement = 18;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 10;
                        OwlAI.maxTimeBetwenMovement = 13;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 8;
                        OwlAI.maxTimeBetwenMovement = 11;
                        break;
                }
                break;

            case 4:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 15;
                        OwlAI.maxTimeBetwenMovement = 17;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 10;
                        OwlAI.maxTimeBetwenMovement = 12;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 8;
                        OwlAI.maxTimeBetwenMovement = 10;
                        break;
                }
                break;

            case 5:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 15;
                        OwlAI.maxTimeBetwenMovement = 19;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 14;
                        OwlAI.maxTimeBetwenMovement = 17;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 9;
                        OwlAI.maxTimeBetwenMovement = 12;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 7;
                        OwlAI.maxTimeBetwenMovement = 10;
                        break;
                }
                break;

            case 6:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 15;
                        OwlAI.maxTimeBetwenMovement = 18;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 14;
                        OwlAI.maxTimeBetwenMovement = 16;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 9;
                        OwlAI.maxTimeBetwenMovement = 11;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 7;
                        OwlAI.maxTimeBetwenMovement = 9;
                        break;
                }
                break;

            case 7:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 15;
                        OwlAI.maxTimeBetwenMovement = 17;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 13;
                        OwlAI.maxTimeBetwenMovement = 16;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 8;
                        OwlAI.maxTimeBetwenMovement = 11;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 6;
                        OwlAI.maxTimeBetwenMovement = 9;
                        break;
                }
                break;

            case 8:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 14;
                        OwlAI.maxTimeBetwenMovement = 17;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 13;
                        OwlAI.maxTimeBetwenMovement = 15;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 8;
                        OwlAI.maxTimeBetwenMovement = 10;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 6;
                        OwlAI.maxTimeBetwenMovement = 8;
                        break;
                }
                break;

            case 9:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 14;
                        OwlAI.maxTimeBetwenMovement = 16;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 12;
                        OwlAI.maxTimeBetwenMovement = 14;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 7;
                        OwlAI.maxTimeBetwenMovement = 10;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 5;
                        OwlAI.maxTimeBetwenMovement = 8;
                        break;
                }
                break;

            case 10:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 15;
                        OwlAI.maxTimeBetwenMovement = 17;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 13;
                        OwlAI.maxTimeBetwenMovement = 16;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 9;
                        OwlAI.maxTimeBetwenMovement = 11;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 7;
                        OwlAI.maxTimeBetwenMovement = 10;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 5;
                        OwlAI.maxTimeBetwenMovement = 8;
                        break;
                }
                break;

            case 11:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 14;
                        OwlAI.maxTimeBetwenMovement = 17;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 13;
                        OwlAI.maxTimeBetwenMovement = 15;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 8;
                        OwlAI.maxTimeBetwenMovement = 11;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 7;
                        OwlAI.maxTimeBetwenMovement = 9;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 5;
                        OwlAI.maxTimeBetwenMovement = 7;
                        break;
                }
                break;

            case 12:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 14;
                        OwlAI.maxTimeBetwenMovement = 16;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 12;
                        OwlAI.maxTimeBetwenMovement = 15;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 8;
                        OwlAI.maxTimeBetwenMovement = 10;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 6;
                        OwlAI.maxTimeBetwenMovement = 9;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 4;
                        OwlAI.maxTimeBetwenMovement = 7;
                        break;
                }
                break;

            case 13:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 13;
                        OwlAI.maxTimeBetwenMovement = 16;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 12;
                        OwlAI.maxTimeBetwenMovement = 14;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 7;
                        OwlAI.maxTimeBetwenMovement = 10;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 6;
                        OwlAI.maxTimeBetwenMovement = 8;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 4;
                        OwlAI.maxTimeBetwenMovement = 6;
                        break;
                }
                break;

            case 14:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 1000000;
                        OwlAI.maxTimeBetwenMovement = 1000000;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 13;
                        OwlAI.maxTimeBetwenMovement = 15;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 11;
                        OwlAI.maxTimeBetwenMovement = 14;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 7;
                        OwlAI.maxTimeBetwenMovement = 9;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 5;
                        OwlAI.maxTimeBetwenMovement = 8;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 3;
                        OwlAI.maxTimeBetwenMovement = 6;
                        break;
                }
                break;

            case 15:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 15;
                        OwlAI.maxTimeBetwenMovement = 17;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 12;
                        OwlAI.maxTimeBetwenMovement = 15;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 11;
                        OwlAI.maxTimeBetwenMovement = 13;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 6;
                        OwlAI.maxTimeBetwenMovement = 9;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 5;
                        OwlAI.maxTimeBetwenMovement = 7;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 3;
                        OwlAI.maxTimeBetwenMovement = 5;
                        break;
                }
                break;

            case 16:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 14;
                        OwlAI.maxTimeBetwenMovement = 17;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 12;
                        OwlAI.maxTimeBetwenMovement = 14;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 10;
                        OwlAI.maxTimeBetwenMovement = 13;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 6;
                        OwlAI.maxTimeBetwenMovement = 8;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 4;
                        OwlAI.maxTimeBetwenMovement = 7;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 2;
                        OwlAI.maxTimeBetwenMovement = 5;
                        break;
                }
                break;

            case 17:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 14;
                        OwlAI.maxTimeBetwenMovement = 16;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 11;
                        OwlAI.maxTimeBetwenMovement = 14;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 10;
                        OwlAI.maxTimeBetwenMovement = 12;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 5;
                        OwlAI.maxTimeBetwenMovement = 8;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 4;
                        OwlAI.maxTimeBetwenMovement = 6;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 2;
                        OwlAI.maxTimeBetwenMovement = 4;
                        break;
                }
                break;

            case 18:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 13;
                        OwlAI.maxTimeBetwenMovement = 16;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 11;
                        OwlAI.maxTimeBetwenMovement = 13;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 9;
                        OwlAI.maxTimeBetwenMovement = 12;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 5;
                        OwlAI.maxTimeBetwenMovement = 7;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 3;
                        OwlAI.maxTimeBetwenMovement = 6;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 1;
                        OwlAI.maxTimeBetwenMovement = 4;
                        break;
                }
                break;

            case 19:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 13;
                        OwlAI.maxTimeBetwenMovement = 15;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 10;
                        OwlAI.maxTimeBetwenMovement = 13;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 9;
                        OwlAI.maxTimeBetwenMovement = 11;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 4;
                        OwlAI.maxTimeBetwenMovement = 7;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 3;
                        OwlAI.maxTimeBetwenMovement = 5;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 1;
                        OwlAI.maxTimeBetwenMovement = 3;
                        break;
                }
                break;

            case 20:
                switch (Main.nightHour)
                {
                    case 12:
                        OwlAI.minTimeBetwenMovement = 11;
                        OwlAI.maxTimeBetwenMovement = 14;
                        break;

                    case 1:
                        OwlAI.minTimeBetwenMovement = 9;
                        OwlAI.maxTimeBetwenMovement = 11;
                        break;

                    case 2:
                        OwlAI.minTimeBetwenMovement = 8;
                        OwlAI.maxTimeBetwenMovement = 10;
                        break;

                    case 3:
                        OwlAI.minTimeBetwenMovement = 4;
                        OwlAI.maxTimeBetwenMovement = 6;
                        break;

                    case 4:
                        OwlAI.minTimeBetwenMovement = 2;
                        OwlAI.maxTimeBetwenMovement = 4;
                        break;

                    case 5:
                        OwlAI.minTimeBetwenMovement = 1;
                        OwlAI.maxTimeBetwenMovement = 2;
                        break;
                }
                break;

            default:
                Debug.LogWarning("SomethingWentWrong");
                break;
        }
    }

    public static void EyeballDemonMovingTime()
	{

	}
}
