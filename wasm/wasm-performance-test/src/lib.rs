

mod utils;

use wasm_bindgen::prelude::*;
use std::collections::HashMap;

#[wasm_bindgen]
pub fn simple_sieve(limit: usize) -> Vec<usize>{
    let mut primes: Vec<usize> = Vec::new();
    let mut potential: Vec<bool> = vec![true; limit + 1];
    potential[0] = false;
    potential[1] = false;
    let limit_v: usize = (limit as f64).sqrt() as usize;
    for i in 2..=limit_v {
        if potential[i]{
            for v in potential.iter_mut().skip(2 * i).step_by(i) {
                *v = false;
            }
        }
    }
    for (i, v) in potential.iter().enumerate(){
        
        if *v{
            primes.push(i);
        }
    }
    return primes
}

#[wasm_bindgen]
pub fn equal_pairs(nums: Vec<usize>) -> usize {
    let mut pairs:usize = 0;

    let mut map:HashMap<usize, usize> = HashMap::new();

    for v in nums.iter(){
        let stat = map.entry(*v).or_insert(0);
        pairs += *stat;
        *stat += 1;
    }

    return pairs;
}