import { PostFromFacebookDataTemplatePage } from './app.po';

describe('PostFromFacebookData App', function() {
  let page: PostFromFacebookDataTemplatePage;

  beforeEach(() => {
    page = new PostFromFacebookDataTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
