use std::io; // importing std libraries input/output
use std::cmp::Ordering; // importing an enum type that has variants of Less, Greater and Equal
use rand::Rng; // importing the rand package

fn main() {
    let secret_number = rand::thread_rng().gen_range(1..=100);
    let mut guesses_left = 10;
    // guess the number game!
    println!("Guess the number game!\n");

    // main game loop
    while guesses_left != 0 {
        println!("You have {guesses_left} guesses left!\nInput a number...");
        let mut guess = String::new(); // define a new mutable string but don't assign it yet

        // read from the std input and write the buffer into a variable. This also includes error handling with .expect()
        io::stdin()
            .read_line(&mut guess)
            .expect("Failed to read line!");
        // .read_line() returns a Result that's an enum which can be either an "Ok" or an "Err"

        // convert the String guess into an unsigned 32bit int. If input is number then return that else just continue
        let guess: u32 = match guess.trim().parse() {
            Ok(num) => num,
            Err(_) => {
                println!("That wasn't a number! Naughty Naughty");
                continue;
            },
        };

        // matching each variant of the enum
        match guess.cmp(&secret_number) {
            Ordering::Less => println!("Too Small!\n"),
            Ordering::Greater => println!("Too Big!\n"),
            Ordering::Equal => {
                // if guess is equal break the loop to quit the game! 
                println!("You win! The number was {secret_number}");
                return; 
            }
        }
        guesses_left = guesses_left - 1; // decrement our guesses_left
    }
    println!("You lost! The number was {secret_number}");
}