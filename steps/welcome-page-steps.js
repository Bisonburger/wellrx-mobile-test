const should = require('chai').should();
const { Given, When, Then } = require('cucumber');

var currentPage = undefined;
var haveInviteCode = false;
var inviteCode = undefined;
var error = undefined;

Given('I start the app for the first time', function () {

        });
Given('I am on the {string} page', function (page) {currentPage = page;});

When('I indicate I have an invite code', function () {
    haveInviteCode = true;
         });
When('I indicate I do not have an invite code', function () {
      haveInviteCode = false;
      });
When('I supply an invite code of {string}', function (code) {
        inviteCode = code;
        error = undefined;
        if( inviteCode === 'VALID') currentPage = 'create-account';
        else error = 'invalid invite code';
        });
When('I indicate I have an existing login', function () {
                  // Write code here that turns the phrase above into concrete actions
                  currentPage = 'login';
                });
              When('I navigate through the on-boarding tutorial', function () {
                         // Write code here that turns the phrase above into concrete actions
                       });
Then('I am navigated to the {string} page', function (pageName) {
           return should.exist( currentPage ) && currentPage.should.equal( pageName );
         });
Then('I remain on the same page', function () {
          return should.exist(currentPage) && currentPage.should.equal( 'welcome' );
        });
        Then('I see an error message for {string}', function (errorMsg) {
                  return should.exist( error ) && error.should.equal( errorMsg );
                 });
