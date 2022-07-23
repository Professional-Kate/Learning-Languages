use ferris_says::say;
use std::io::{stdout, BufWriter};

fn main() {
    let stdout = stdout();
    let message = String::from("Hello, Tea!"); // define a string and assign that to "message"
    let width = message.chars().count(); // break up the sting into a char[] then count every element

    let mut writer = BufWriter::new(stdout.lock()); // define a mutable variable so it can be borrowed later 
    say(message.as_bytes(), width, &mut writer).unwrap();
}