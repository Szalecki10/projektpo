#include <iostream>
#include <random>
#include <fstream>
#include <vector>
#include <algorithm>

typedef std::vector<int> Koszty;



int rand_num(int start, int end)
{
    int r = end - start;
    int rnum = start + rand() % r;
    return rnum;
}

Koszty rand_koszty(int ilosc, int makskoszt, int makskosztjednego) {
    Koszty koszt;
    int sumator = 0;
    for (int i=0 ; i < ilosc; i++) {
        for (int i = 0; i < 5; i++)
        {
            if (sumator < ilosc * makskoszt) {
                koszt.push_back(rand_num(0, makskosztjednego+1));
            }
            else {
                koszt.push_back(0);
            }
        }
    }
    random_shuffle(koszt.begin(), koszt.end());
    return koszt;
}

int main()
{
    std::ofstream zapis("karty.json");

    srand((unsigned)time(0));
    zapis << "[" << std::endl;
    Koszty temp = rand_koszty(40, 7, 2);
    for (int i = 10; i<50; i++) {
        zapis << "{" << std::endl << "   \"points\" : " << rand_num(0, 1) << "," << std::endl;
        zapis << "  \"cardID\" : " << i << "," << std::endl;
        zapis << "  \"cardLevel\" : " << 1 << "," << std::endl;
        zapis << "  \"emeraldCost\" : " << temp[0] << "," << std::endl;
        zapis << "  \"diamondCost\" : " << temp[1] << "," << std::endl;
        zapis << "  \"sapphireCost\" : " << temp[2] << "," << std::endl;
        zapis << "  \"onyxCost\" : " << temp[3] << "," << std::endl;
        zapis << "  \"rubyCost\" : " << temp[4] << "," << std::endl;
        zapis << "  \"colorGainedID\" : " << rand_num(0,6) << "" << std::endl;
        zapis << "}," << std::endl;

    }

    
    Koszty temp1 = rand_koszty(30, 10,7);
    for (int i = 100; i < 130; i++) {
        
        zapis << "{" << std::endl << "   \"points\" : " << rand_num(1, 2) << "," << std::endl;
        zapis << "  \"cardID\" : " << i << "," << std::endl;
        zapis << "  \"cardLevel\" : " << 2 << "," << std::endl;
        zapis << "  \"emeraldCost\" : " << temp1[0] << "," << std::endl;
        zapis << "  \"diamondCost\" : " << temp1[1] << "," << std::endl;
        zapis << "  \"sapphireCost\" : " << temp1[2] << "," << std::endl;
        zapis << "  \"onyxCost\" : " << temp1[3] << "," << std::endl;
        zapis << "  \"rubyCost\" : " << temp1[4] << "," << std::endl;
        zapis << "  \"colorGainedID\" : " << rand_num(0, 6) << "" << std::endl;
        zapis << "}," << std::endl;

    }

    Koszty temp3 = rand_koszty(20, 16,9);
    for (int i = 1000; i < 1020; i++) {

        zapis << "{" << std::endl << "   \"points\" : " << rand_num(3, 4) << "," << std::endl;
        zapis << "  \"cardID\" : " << i << "," << std::endl;
        zapis << "  \"cardLevel\" : " << 3 << "," << std::endl;
        zapis << "  \"emeraldCost\" : " << temp3[0] << "," << std::endl;
        zapis << "  \"diamondCost\" : " << temp3[1] << "," << std::endl;
        zapis << "  \"sapphireCost\" : " << temp3[2] << "," << std::endl;
        zapis << "  \"onyxCost\" : " << temp3[3] << "," << std::endl;
        zapis << "  \"rubyCost\" : " << temp3[4] << "," << std::endl;
        zapis << "  \"colorGainedID\" : " << rand_num(0, 6) << "" << std::endl;
        zapis << "}," << std::endl;

    }
    zapis << "]" << std::endl;

    std::ofstream zapis1("noblisci.json");
    zapis1 << "[" << std::endl;
    Koszty temp4 = rand_koszty(20, 16, 5);
    for (int i = 1; i < 20; i++) {
        
        zapis1 << "{" << std::endl;
        zapis1 << "  \"nobleID\" : " << i << "," << std::endl;
        zapis1<< "   \"pointsGiving\" : " << rand_num(3, 4) << "," << std::endl;
        zapis1 << "  \"cardLevel\" : " << 3 << "," << std::endl;
        zapis1 << "  \"emeraldCost\" : " << temp4[0] << "," << std::endl;
        zapis1 << "  \"diamondCost\" : " << temp4[1] << "," << std::endl;
        zapis1 << "  \"sapphireCost\" : " << temp4[2] << "," << std::endl;
        zapis1 << "  \"onyxCost\" : " << temp4[3] << "," << std::endl;
        zapis1 << "  \"rubyCost\" : " << temp4[4]  << std::endl;
        zapis1 << "}," << std::endl;

    }
    zapis1 << "]" << std::endl;

    return 0;

}

