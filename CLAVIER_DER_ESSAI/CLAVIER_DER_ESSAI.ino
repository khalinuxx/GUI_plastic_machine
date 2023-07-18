//macros
#define KEYTIME 1500


// function prototype

bool AlphaKey(int button);
void AlphaClick(char x , char y , char num, char *chif, unsigned long LastTime, int buttonIndex, int Lastbutton );

//variables defenition
const int numRows = 8;       // Nombre de lignes du clavier
const int numCols = 8;       // Nombre de colonnes du clavier
unsigned long LastTime = 0;  // contain the time for the last click
bool NUM = true;
char win = 'a';
char chif1 = 'A';
char chif2 = 'D';
char chif3 ;
char chif4 = 'J';
char chif5 = 'M';
char chif6 = 'P';
char chif7 = 'S';
char chif8 = 'V';
char chif9 = 'Y';
int Lastbutton;
// Broches de connexion des lignes et des colonnes du clavier
int rowPins[numRows] = {36, 34, 32, 30, 28, 26, 24, 22};
int colPins[numCols] = {52, 50, 48, 46, 47, 49, 51, 53};

const char* buttonNames[numRows][numCols] = {
  {"Button 1", "Button 2", "PORTILLON FERMER", "EPAISSEUR MOULE -", "Button 5", "Button 6", "CHIFFRE 7", "Button 8"},
  {"Button 9", "Button 10", "UNITE RECUL", "CHARIOT IN", "Button 13", "SYMBOLE -", "CHIFFRE 6", "Button 16"},

  {"z5", "MOTEUR PRINCIPAL", "ROTATION VIS", "AVANCE EJECTEUR", "Button 21", "SYMBOLE +", "CHIFFRE 5", "ALARME RESET"},
  {"z4", "CHAUFFAGE", "RECUL VIS", "FERMETURE MOULE", "BOUTON 29", "ALPHA/NUMEROS", "CHIFFRE 4", "PRINT"},
  {"z3", "MONTAGE MOULE", "PORTILLON OUVRIR", "EPAISSEUR MOULE +", "yD"/*Button DROIT*/, "ENTER", "CHIFFRE 3", "HELP"},
  {"z2", "AUTOMATIQUE", "UNITE AVANCE", "CHARIOT AVANCE", "yG"/*Butoon HAUT*/, "EFFACER", "CHIFFRE 2", "NEXT"},
  {"z1", "SEMI AUTOMATIQUE", "PURGE AUTOMATIQUE", "RECUL EJECTEUR", "yB"/*Butoon BAS*/, "CHIFFRE 9", "CHIFFRE 1", "PREVIOUS"},

  {"BOUTON", "MANUEL", "INJECTION", "OUVERTURE MOULE", "yH"/*Butoon HAUT*/, "CHIFFRE 8", "CHIFFRE 0", "MENU"}
};


void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  Serial.println("CLAVIER ROCKLAND");

  for (int i = 0; i < numRows; i++) {
    pinMode(rowPins[i], OUTPUT);
    digitalWrite(rowPins[i], HIGH);  // Désactive les résistances de pull-up
  }

  // Initialise les broches des colonnes en entrée avec résistances de pull-up activées
  for (int i = 0; i < numCols; i++) {
    pinMode(colPins[i], INPUT_PULLUP);
  }

  Serial.println(win);
}






void loop() {
  // Parcours des lignes
  for (int row = 0; row < numRows; row++) {
    // Active la ligne actuelle
    digitalWrite(rowPins[row], LOW);

    // Parcours des colonnes
    for (int col = 0; col < numCols; col++) {
      // Vérifie si une touche est appuyée dans la colonne actuelle
      if (digitalRead(colPins[col]) == LOW) {
        // Touche appuyée détectée
        int buttonIndex = row * numCols + col;

        //Serial.println(buttonIndex);

        //  if( buttonIndex != Lastbutton)
        //  {

        if (buttonNames[row][col] == "BOUTON" )
        {

          //                           if(win != 'f')
          //                               win++;
          //                           else
          //                               win='a';
          (win != 'f') ? win++ : win = 'a';
          Serial.println(win);

        } else if (buttonNames[row][col] == "CHIFFRE 1" )
        {
          //                          Serial.println(buttonIndex);
          //                          Serial.println(Lastbutton);

          AlphaClick('A' , 'C' , '1', &chif3, LastTime, buttonIndex, Lastbutton );
        }

        else if (buttonNames[row][col] == "CHIFFRE 2" )
        {
          AlphaClick('D' , 'F' , '2', &chif3, LastTime, buttonIndex, Lastbutton );
        }
        else if (buttonNames[row][col] == "CHIFFRE 3" )
        {
          //chif3='G';
          AlphaClick('G' , 'I' , '3', &chif3, LastTime, buttonIndex, Lastbutton );

        }
        else if (buttonNames[row][col] == "CHIFFRE 4" )
        {
          AlphaClick('J' , 'L' , '4', &chif3, LastTime, buttonIndex, Lastbutton );
        }
        else if (buttonNames[row][col] == "CHIFFRE 5" )
        {
          AlphaClick('M' , 'O' , '5', &chif3, LastTime, buttonIndex, Lastbutton );

        } else if (buttonNames[row][col] == "CHIFFRE 6" )
        {
          AlphaClick('P' , 'R' , '6', &chif3, LastTime, buttonIndex, Lastbutton );
        }
        else if (buttonNames[row][col] == "CHIFFRE 7" )
        {
          AlphaClick('S' , 'U' , '7', &chif3, LastTime, buttonIndex, Lastbutton );
        }
        else if (buttonNames[row][col] == "CHIFFRE 8" )
        {
          AlphaClick('V' , 'X' , '8', &chif3, LastTime, buttonIndex, Lastbutton );
        }
        else if (buttonNames[row][col] == "CHIFFRE 9" )
        {
          if (NUM)
          {
            Serial.println('9');

          } else
          {
            if (( buttonIndex == Lastbutton ) && ( (millis() - LastTime) <= KEYTIME))
            {
              //(chif9 != '-') ? chif9++ : chif9 = 'Y';
              //Serial.println(chif9);
              switch (chif3)
              {
                case 'Y':
                  chif3 = 'Z';
                  Serial.println('x');
                  Serial.println(chif3);
                  break;
                case 'Z':
                  chif3 = '-';
                  Serial.println('x');
                  Serial.println(chif3);
                  break;
                case '-':
                  chif3 = 'Y';
                  Serial.println('x');
                  Serial.println(chif3);
                  break;

              }
            }
            else
            {

              chif3 = 'Y';
              Serial.println(chif3);
            }
          }
        }
        else if (buttonNames[row][col] == "ALPHA/NUMEROS" )
        {
          NUM =  !NUM ;
        }
        else if(buttonNames[row][col]=="EFFACER")
            {
              Serial.println('x');
            }
        else
        {
          Serial.println(buttonNames[row][col]);
        }
        Lastbutton = buttonIndex;
        LastTime = millis();
        // Vous pouvez effectuer des actions spécifiques en fonction du bouton appuyé

        // Attendez que la touche soit relâchée pour éviter les répétitions
        while (digitalRead(colPins[col]) == LOW) {
          delay(100);
        }
        //  }

        //Serial.println(Lastbutton);
      } else
      {
        //Lastbutton = 0;
      }

    }

    // Désactive la ligne actuelle
    digitalWrite(rowPins[row], HIGH);
  }
}



bool AlphaKey(int button)
{
  int x = button;
  switch (x)
  {
    case 13:
      return true ;
      break;

    case 45:
      return true ;
      break;

    case 37:
      return true ;
      break;

    case 62:
      return true ;
      break;

    case 21:
      return true ;
      break;

    case 29:
      return true ;
      break;

    case 54:
      return true ;
      break;

    case 46:
      return true ;
      break;

    case 38:
      return true ;
      break;

    case 30:
      return true ;
      break;

    case 22:
      return true ;
      break;

    case 14:
      return true ;
      break;

    case 6:
      return true ;
      break;

    case 61:
      return true ;
      break;

    case 53:
      return true ;
      break;

    default:
      return false ;

  }


}

void AlphaClick(char x , char y , char num, char *chif, unsigned long LastTime, int buttonIndex, int Lastbutton )
{
  //*chif = x;

  if (NUM)
  {
    Serial.println(num);

  } else
  {
    if (( buttonIndex == Lastbutton ) && ( (millis() - LastTime) <= KEYTIME))
    {
      (*chif != y) ? (*chif)++ : *chif = x;
      //      if((*chif) != y)
      //            (*chif)++;
      //          else
      //            (*chif)=x;
      Serial.println('x');
      Serial.println(*chif);
    } else
    {

      (*chif) = x;
      Serial.println(*chif);
    }
  }



}
