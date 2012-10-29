﻿using System;
using System.Collections.Generic;
using System.IO;
using Fusee.Engine;
using Fusee.Math;

namespace Examples
{
    public class Simple : RenderCanvas
    {
        protected string _vs = @"
/* Copies incoming vertex color without change.
    * Applies the transformation matrix to vertex position.
    */
attribute vec4 fuColor;
attribute vec3 fuVertex;
attribute vec3 fuNormal;
        
varying vec4 vColor;
varying vec3 vNormal;
        
uniform mat4 FUSEE_MVP;
uniform mat4 FUSEE_ITMV;

void main()
{
    gl_Position = FUSEE_MVP * vec4(fuVertex, 1.0);
    // vColor = vec4(fuNormal * 0.5 + 0.5, 1.0);
    // vec4 norm4 = FUSEE_MVP * vec4(fuNormal, 0.0);
    // vNormal = norm4.xyz;
    vNormal = mat3(FUSEE_ITMV) * fuNormal;
}";

        protected string _ps = @"
/* Copies incoming fragment color without change. */
#ifdef GL_ES
precision highp float;
#endif
        
varying vec4 vColor;
varying vec3 vNormal;

void main()
{
    gl_FragColor = vec4(0.08, 0.08, 0.08, 1.0) * dot(vNormal, vec3(0, 0, 1));
}";
        protected string _ps2 = @"
/* Copies incoming fragment color without change. */
#ifdef GL_ES
precision highp float;
#endif
        
varying vec4 vColor;
varying vec3 vNormal;

void main()
{
    gl_FragColor = vec4(0.03, 0.03, 0.13, 1.0) * dot(vNormal, vec3(0, 0, 1));
}";

        private static float _angleHorz = 0.0f, _angleVert = 0.0f, _angleVelHorz = 0, _angleVelVert = 0, _rotationSpeed = 10.0f, _damping = 0.95f, _moveX = 0.0f, _moveY = 0.0f, _moveZ = 0.0f;
        private World _world;
        protected ShaderProgram sp2;
        protected ShaderProgram sp;
        
        public override void Init()
        {
            _world = new World(RC,In);
            Geometry geo = MeshReader.ReadWavefrontObj(new StreamReader(@"SampleObj/Hut_obj2.obj.model"));
            _world.addObject(geo,0,0,0);
            Geometry user = MeshReader.ReadWavefrontObj(new StreamReader(@"SampleObj/Ninja.obj.model"));
            
            sp2 = RC.CreateShader(_vs, _ps2);
            sp = RC.CreateShader(_vs, _ps);
            _angleHorz = 0;
            _rotationSpeed = 100.0f;
            RC.ClearColor = new float4(0, 0, 0, 1);
        }

        public override void RenderAFrame()
        {
            RC.Clear(ClearFlags.Color | ClearFlags.Depth);


            //if (In.IsButtonDown(MouseButtons.Left))
            //{
            _angleVelHorz += _rotationSpeed*In.GetAxis(InputAxis.MouseX);//  *(float)DeltaTime;
              //  _angleVelVert = _rotationSpeed * In.GetAxis(InputAxis.MouseY) * (float)DeltaTime;
            //}
            //else
            //{
            //    _angleVelHorz *= _damping;
            //    _angleVelVert *= _damping;
            //}
            //_angleHorz += _angleVelHorz;
            //_angleVert += _angleVelVert;

            if (In.IsKeyDown(KeyCodes.Left))
            {
                _angleHorz -= _rotationSpeed * (float)DeltaTime;
            }
            if (In.IsKeyDown(KeyCodes.Right))
            {
                _angleHorz += _rotationSpeed * (float)DeltaTime;
            }
            if (In.IsKeyDown(KeyCodes.Up))
            {
                _angleVert -= _rotationSpeed * (float)DeltaTime;
            }
            if (In.IsKeyDown(KeyCodes.Down))
            {
                _angleVert += _rotationSpeed * (float)DeltaTime;
            }
            if (In.IsKeyDown(KeyCodes.W))
            {
                _moveZ += _rotationSpeed * (float)DeltaTime;
            }
            if (In.IsKeyDown(KeyCodes.S))
            {
                _moveZ -= _rotationSpeed * (float)DeltaTime;
            }
            if (In.IsKeyDown(KeyCodes.A))
            {
                _moveX += _rotationSpeed * (float)DeltaTime;
            }
            if (In.IsKeyDown(KeyCodes.D))
            {
                _moveX -= _rotationSpeed * (float)DeltaTime;
            }
            RC.SetShader(sp);
            RC.ModelView = float4x4.CreateRotationY((float)0) * float4x4.CreateRotationX(0) * float4x4.CreateTranslation(_moveX, _moveY, _moveZ + 80) * float4x4.LookAt(0, 50, 200, _angleVelHorz, 50, 0, 0, 1, 0) * float4x4.CreateTranslation(0, 0, -80);

            
            RC.SetShader(sp2);
            RC.ModelView = float4x4.CreateRotationY((float)Math.PI * 3 / 2) * float4x4.CreateRotationX(0) * float4x4.CreateTranslation(0,0,0) * float4x4.LookAt(0, 80, 80, 0, 50, 0, 0, 1, 0);
            
            
            _world.RenderWorld(_angleVert);
            Present();
        }

        public override void Resize()
        {
            RC.Viewport(0, 0, Width, Height);

            float aspectRatio = Width / (float)Height;
            RC.Projection = float4x4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, aspectRatio, 1, 5000);
        }

        public static void Main()
        {
            Simple app = new Simple();
            app.Run();
        }

    
    }
}