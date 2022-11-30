describe('empty spec', () => {
  const Langini = {
    accessButton: () => cy.get('[id="access"]'),
    logo: () => cy.get('[id="logo"]'),
  }

  beforeEach('passes', () => {
    cy.visit('http://localhost:3000/events')
  })

  it('page have access button', () => {
    Langini.accessButton().should('exist');
  })

  it('page have logo', () => {
    Langini.logo().should('exist');
  })

  /* it('go to login page', () => {
    Langini.accessButton().click().visit('https://dev-c8roe23ts7o24plt.us.auth0.com/');
  })*/
})
