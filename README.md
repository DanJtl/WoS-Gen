# **FITMASTER**
"FITMASTER" is a website where you can generate a free personalized workout schedule.
<br/>
This website is for people that wants to begin a healthier lifestyle and to start workout.
All they need to do is to fill out a form, and after they submit - a free personalized workout schedule is created.
<br/><br/>
Note! - Each code block and written words in this project is 100% made with pair programming, by Daniel- and Jimmy Junttila.
<br/><br/>
![website will work in any media browser](/responsive_layout.png)
<br/><br/>

## Features


 **Header navigation bar**

    - The navigation bar includes links to Home, Generator and Login button (login button will be connected to a database in a future update).
    - This full responsive navigation bar allow all users to easy navigate to all pages on this site, without the need of the "go back" button.
    - A logo is shown at left with a link to homepage.

![navigation bar](./Wos-Gen/wwwroot/navbar.png)
<br/><br/>

 **Main image**

    - The main image is a picture of fitness girl (associates with a fitness lifestyle).
    - And this image also got an overlay text, that tell the user that he/she is on the perfect site he/she was looking for.
    - Also a CTA button is connected, to the "Generator" page.

![hero-image on homepage](./Wos-Gen/wwwroot/hero_image.png)
<br/><br/>

 **ScheduleGuide section**

    - This section got 3 "cards" with title, paragraph and icons. This guide let the user to easy understand how to generate a personalized workout schedule, with 3 steps only.
    - Below the guide there's a button that will take them to the "Generator" page.

![blogpost section](./Wos-Gen/wwwroot/schedule_guide.png)
<br/><br/>

 **Footer section**

    - The footer section got 3 social media icons (facebook, twitter, instagram).
    - This section also have a copyright text (below the social media icons).

![footer image](./Wos-Gen/wwwroot/footer.png)
<br/><br/>

 **Generator page**

    - The 'Generator' page have a banner (with a fitness girl) and a text that the user now can input their name, email and choose their specific options.
    - Below the banner there is a form with all the input fields the user needs to fill i.

![signup image](./Wos-Gen/wwwroot/schedule_form.png)
<br/><br/>

 **The workout schedule**

    - The 'workout schedule' is shown when the user have input all the fields and clicked the "Create Schedule" button.
    - User needs to fill in ALL the fields, otherwise there will be a message that he/she need to fill in all the options available.
    - Name and Email field is regular text inputs, and 'Goal', 'Location' and 'Experience is dropdown option fields.
    - A 'spinner' is shown for 2,5s after user click the "Create Schedule" button, to simulate that the generator is "working".

![login image](./Wos-Gen/wwwroot/schedule_generated.png)
<br/><br/>


## Design


 **Colors and fonts**

    - Background color: #FFF
    - Logo color: #000 and #5cb85c
    - Body font color: #000
    - Button color: #0275d8
    - Heading font color: #000
    - Fonts used: 'Helvetica Neue' and Helvetica, Arial, sans-serif as "backup" fonts.

<br/><br/>


## UX

The target audience are likely individuals who are interested in leading a healthy and active lifestyle.
<br/><br/>
This may include individuals who are looking to start or maintain a regular workout routine, improve their fitness levels, or track their progress.
The target group may also include individuals who are looking for a personalized workout plan that caters to their specific goals and needs,
such as weight loss, muscle building, or rehabilitation after an injury.
<br/><br/>
Additionally, the target group may include individuals who are short on time and prefer a convenient solution for planning their workouts,
or those who are looking for guidance and inspiration in their fitness journey.
<br/><br/>

 **User stories**

NEW USER: I am interested in starting training and wanna know more about this lifestyle!<br/>
RETURNING USER: User can come back anytime to check or change their workout schedule.


    - USER STORY: Generate workout schedule
    - As a Site User, I can add personal inputs so that I can get a customized workout schedule.

    - USER STORY: Calculate bmi
    - As a Site User, I can add personal inputs so that I can view my BMI.

    - USER STORY: View schedule
    - As a Site User, I can click on a button so that I can see the full schedule.

    - USER STORY: View guide
    - As a Site User, I can view a simple guide so that I can easily generate my own schedule.

    - USER STORY: Navigate the website
    - As a Site User, I can view all links so I can easily navigate the website.

    - USER STORY: Edit current workout schedule
    - As a Site User, I can edit my schedule so I can adapt it to my personal preferences.

    - USER STORY: Account registration
    - As a Site User I can register an account so that my personal information and schedules gets stored.

    - USER STORY: Contact website
    - As a Site User, I can easily find contact information so that I can reach out to the site owner. 

    - USER STORY: Receive reminders
    - As a Site User, I can receive reminders so that I don’t miss out my workout session.

    - USER STORY: Track progress
    - As I Site User, I can view my past workouts so that I can track my progress. 

    - USER STORY: Share schedule
    - As a Site User, I can select different options so that I can easily share my schedules with friends.

    - USER STORY: Download app
    - As a Site User, I can download an app so that I can easily see my schedule in my phone.


 **Future updates**

    - Add 'Account registration', so all users will be saved in our future database.
    - Add a 'share schedule' function, so users can share their progress to their friends.
    - 'Track progress' function so users easily can follow their progress.
    - Create an app for smartphones, so users easily can stay up to date with their schedule.
    - Add more pages (contact, about, articles etc) and content to the website. 
<br/><br/>

 **Site goal**

The main goal of this website is to provide a comprehensive and convenient solution for individuals looking to improve their fitness.
The website aims to make it easy for users to create a personalized workout plan that fits their goals, schedule, and fitness level.
<br/><br/>
By providing customized workout schedules, the website helps users stay motivated and on track with their fitness journey.
<br/><br/>
Additionally, the website may aim to provide helpful resources and information on exercise, nutrition, and overall wellness to support users in their quest for a healthy lifestyle.
The ultimate goal of the website is to help users achieve their fitness goals and maintain a sustainable and active lifestyle.
<br/><br/>

 **Business owner goal**

The business owner's goal is to generate revenue by offering a paid service or selling related products.
<br/><br/>
The business owner may also aim to establish their brand as a trusted and authoritative source of information on fitness and wellness,
which could lead to increased customer loyalty and future business opportunities.
<br/><br/>
The business owner may also aim to grow their customer base by attracting new users through marketing and advertising efforts,
as well as providing a positive user experience and high-quality service that encourages customer referrals.
<br/><br/>
Additionally, the business owner may aim to gather valuable data and insights on their customers' fitness and wellness habits, which could inform future product development and marketing strategies.
<br/><br/>
Ultimately, the business owner's goal is to create a profitable and sustainable business by providing valuable solutions to meet the needs of their target market.
<br/><br/>

## Testing

Manually tested all links (login button and social media icons is not yet connected), buttons on every page in different browsers with no errors.
<br/><br/>

 **Validator testing**

    - 'Lighthouse' with website tested, with good score (SEO is not yet implemented, will be updated in a future 'issue').


![Lighthouse](./Wos-Gen/wwwroot/lighthouse.png)

**xUnit tests**

    - 'UserTests.cs
    - 'WorkoutSchedule.cs
    All tests passed without any problems!
<br/><br/>

## Bugs

    - No bugs detected.

## Unfixed bugs

    - No unfixed bugs.

## Technologies

* **Languages used**

    - HTML
    - CSS
    - C#


## Programs and apps

    - Visual Studio, used for code writing.
    - Github, store data/repo.
    - Git, version control.
    - Bootstrap 5, css framework and icons.
    - Blazor Server App.


## Credits


 **Content**

    - Fonts imported from https://fonts.google.com/
    - Color palette picked from https://colorhunt.co/
<br/><br/>

 **Media**

    - All the images taken from https://www.canva.com/
    - The icons is taken from bootstrap icons.
    - Used Canva for scaling the images.
<br/><br/>


[Back to Top](#FITMASTER)