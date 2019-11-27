import React from 'react';

const span = (<span className='divider'> | </span>)
const Footer = (props) => {
    return (
        <div className="container-fluid">
            <div className='d-flex'>
                 <div>
                <div className='mb-2 links'>
                    Terms of Use {span} Privacy Policy {span} Trademarks {span} License Agreements
                </div>
                <div className='copyright'>
                    Copyright © 2019 Software Corporation and/or its subsidiaries or affiliates. All Rights Reserved.
                </div>
                </div>
                <div className='d-flex ml-auto'>
                    <div className="social">
                        <a href="https://www.facebook.com/KendoUI/"><img src="./img/facebook.png" alt="facebook" /></a>
                        <a href="https://twitter.com/kendoreact"><img src="./img/twitter.png" alt="twitter" /></a>
                        <a href="https://www.youtube.com/results?search_query=kendoreact"><img src="./img/youtube.png" alt="youtube" /></a>
                        <a href="https://www.linkedin.com/showcase/telerik/"><img src="./img/linkedin.png" alt="linkedin" /></a>
                    </div>
                </div>
            </div>
        </div>
    )
}

export default Footer;