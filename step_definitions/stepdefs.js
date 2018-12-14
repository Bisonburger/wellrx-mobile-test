const should = require('chai').should();
const { Given, When, Then } = require('cucumber');

function isItFriday(today){
    return today === 'Friday'? 'TGIF':'Nope';
}

Given( 'today is {string}', (given) => this.today = given );
When( 'I ask if its Friday yet', () => this.actualAnswer = isItFriday(this.today) );
Then( 'I should be told {string}', (expected)=> should.exist( expected) && expected.should.equal(this.actualAnswer) );