const should = require('chai').should();
const { Given, When, Then } = require('cucumber');

Given('I start the app for the first time', function () { this.currentPage = 'welcome'});

Given('I am on the {string} page', function (page) { this.currentPage = page;});

When('I indicate I have an invite code', function () {this.haveInviteCode = true;});

When('I indicate I do not have an invite code', function () { this.haveInviteCode = false;});

When('I supply an invite code of {string}', function (code) {
  this.currentPage = (code === 'VALID' )? 'create-account' : 'welcome';
  this.error = (code === 'VALID' )? undefined : 'invalid code';
});

When('I indicate I have an existing login', function () { this.currentPage = 'login';});
When('I navigate through the on-boarding tutorial', function () { this.currentPage = 'home'});
Then('I am navigated to the {string} page', function (pageName) { this.currentPage.should.equal( pageName )});
Then('I remain on the same page', function () { this.currentPage.should.equal('welcome'); });
Then('I do not see an error', function() { (this.error !== undefined).should.be.false; });
Then('I see an error message for {string}', function (errMsg) { errMsg.should.equal( this.error ); });
