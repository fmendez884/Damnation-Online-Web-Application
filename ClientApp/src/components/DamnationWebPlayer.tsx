import React from "react";
// import ReactDom from "react-dom"
// import { connect } from "react-redux";

import Unity, { UnityContext } from "react-unity-webgl";

// import GobletFire from "./GobletFire";

export default class DamnationWebPlayer extends React.Component {
  
  // unityContext = new UnityContext(
  //   "./Build/damnation-web.json",
  //   "./Build/UnityLoader.js",
  //   {
  //     adjustOnWindowResize: false

  //   }
  // );

    //let isProduction = () => {

    //    if (process.env.NODE_ENV === 'production') {
    //        return true;
    //    }
    //}


    isProduction = () => {
        if (process.env.NODE_ENV === 'production') {
            return true;
        }
        return false;
    }
        
  devUnityContext = new UnityContext({
    loaderUrl: "./Build/WebGLBuild.loader.js",
    dataUrl: "./Build/WebGLBuild.data",
    frameworkUrl: "./Build/WebGLBuild.framework.js",
    codeUrl: "./Build/WebGLBuild.wasm",
  });

    prodUnityContext = new UnityContext({
        loaderUrl: "./Build/WebGLBuild.loader.js",
        dataUrl: "./Build/WebGLBuild.data",
        frameworkUrl: "./Build/WebGLBuild.framework.js",
        codeUrl: "./Build/WebGLBuild.wasm",
    });



  webPlayerWidth = 1000;
  
  // constructor(props: any) {
  //   super(props);
    

  //   // Next up create a new Unity Content object to 
  //   // initialise and define your WebGL build. The 
  //   // paths are relative from your index file.

  // }

  render() {

    // Finally render the Unity component and pass 
    // the Unity content through the props.

    return (
    
        <div className="WebPlayer" style={{ width: this.webPlayerWidth }}>
            <Unity unityContext={this.isProduction() ? this.prodUnityContext : this.devUnityContext} 
            style={{width: this.webPlayerWidth}}
            className="game-canvas"/>
        </div> 
      
    );
  }
  
    // render() {
      
    //     return (
            
    //       <div id="unityContainer" style={{width: 960, height: 600}}></div>
          
    //     );
    // }
}