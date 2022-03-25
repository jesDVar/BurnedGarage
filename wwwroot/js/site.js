// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
console.log('Welcome to the console, today\'s date is: ')

dateToday();

console.info('There\'s a (copy)cat living in the code')
console.warn('You wont find anything fishy here!')

function dateToday() {

let today = new Date().toISOString().slice(0, 10)
    console.log(today)
};

console.groupCollapsed('Knock knock...')

console.error('Error when trying to reach User, is User still there?')

console.groupEnd();
