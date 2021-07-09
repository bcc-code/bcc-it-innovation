#include <bits/stdc++.h>

using namespace std;

vector<int> simple_sieve(int limit){
    vector<int> primes;
    vector<bool> possible(limit);
    for(int i = 0; i < limit; i++){
        possible[i] = true;
    }
    int limit_v = sqrt((double)limit);

    for(int i = 2; i <= limit_v; i++){
        if(possible[i]){
            for(int j = 2 * i; j < limit; j += i){
                possible[j] = false;
            }
        }
    }
    for(int i = 2; i <= limit; i++){
        if(possible[i])
            primes.push_back(i);
    }
    return primes;
}

int main(){
    auto start = chrono::high_resolution_clock::now();
    vector<int> primes = simple_sieve(10000000);
    
    auto stop = chrono::high_resolution_clock::now();
  
    auto duration = chrono::duration_cast<chrono::milliseconds>(stop - start);

    cout<<"Result: "<<primes.size()<<", Elapsed: "<<duration.count()<<"\n";

    return 0;
}